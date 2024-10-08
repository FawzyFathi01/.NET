using Microsoft.EntityFrameworkCore;

namespace Day_2_MVC_App01.Models
{
    public class ITIMVCContext:DbContext
    {
        public DbSet<Employee> Employee {  get; set; }
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
    }
}
