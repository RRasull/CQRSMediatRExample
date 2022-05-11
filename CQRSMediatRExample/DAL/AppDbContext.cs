using CQRSMediatRExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRExample.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name="Samsung",Price=800 },
                new Product { Id = 2, Name = "Iphone", Price = 1200 },
                new Product { Id = 3, Name = "Xiaomi", Price = 600 },
                new Product { Id = 4, Name = "Nokia", Price = 20 }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
