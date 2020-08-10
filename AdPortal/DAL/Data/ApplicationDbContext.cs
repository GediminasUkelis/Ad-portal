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
          

            base.OnModelCreating(modelBuilder);
        }
    }
}
