using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Contracts;

namespace DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<User> Users { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(c => c.Image).WithOne(i => i.Product).HasForeignKey(i => i.ProductId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Vehicle>().HasOne(x => x.BikeDetails).WithOne(x => x.Vehicle).HasForeignKey(typeof(BikeDetails), "Id").OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Vehicle>().HasOne(x => x.CarDetails).WithOne(x => x.Vehicle).HasForeignKey(typeof(CarDetails), "Id").OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
