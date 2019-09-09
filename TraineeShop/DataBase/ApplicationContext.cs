using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TraineeShop.Models;

namespace TraineeShop.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=zxcasdqwe");
        }

        
    }
}
