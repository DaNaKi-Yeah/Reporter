using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using REPORTer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.DAL.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string? str = config["Action"];
            string? str1 = config["ConnectionString"];
            string? str2 = config
                .GetSection("ConnectionStrings")
                ["ConnectionString"];

            string? connectionString = config
                .GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }
    }
}
