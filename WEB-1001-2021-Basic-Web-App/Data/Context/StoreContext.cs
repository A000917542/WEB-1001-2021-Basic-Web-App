using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_1001_2021_Basic_Web_App.Data;

namespace WEB_1001_2021_Basic_Web_App.Data.Context
{
    public class StoreContext
        : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().Property(t => t.Price)
                .HasPrecision(18, 10);
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
