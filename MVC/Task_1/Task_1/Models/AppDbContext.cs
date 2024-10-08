using Microsoft.EntityFrameworkCore;

namespace Task_1.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();
            var constr = configuration.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>()
            .HasOne(d => d.Manager)
            .WithMany() // No reverse navigation from Employee to Department for Manager
            .HasForeignKey(d => d.ManagerId)
            .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Manager if linked to a Department

            modelBuilder.Entity<Department>()
            .HasMany(d => d.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DeptID)
            .OnDelete(DeleteBehavior.SetNull);

        }

    }
}
