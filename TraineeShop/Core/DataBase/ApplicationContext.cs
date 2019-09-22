using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TraineeShop.Models;

namespace TraineeShop.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
             
          var configuration = builder.Build();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CarShop;Username=postgres;Password=qwerty23");
        }


    }
}
