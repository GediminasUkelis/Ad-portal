using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Contracts;

namespace DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Image> Image { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorbike> Motorbikes { get; set; }
        public DbSet<User> Users { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasMany(c => c.Image).WithOne(i => i.Car).HasForeignKey(i => i.CarId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Motorbike>().HasMany(c => c.Image).WithOne(i => i.Motorbike).HasForeignKey(i => i.MotorbikeId).OnDelete(DeleteBehavior.ClientCascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
