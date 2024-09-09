using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_1
{
    internal class AppDpContext:DbContext
    {
        public DbSet<Wallets> Wallets { get; set; } = null!;

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
