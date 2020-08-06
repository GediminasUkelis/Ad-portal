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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<Defects> Defects { get; set; }
        public DbSet<Diameter> Diameters { get; set; }
        public DbSet<Doors> Doors { get; set; }
        public DbSet<FrameType> FrameTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Height> Heights { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerModel> ManufacturerModels { get; set; }
        public DbSet<Motorbike> Motorbikes { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SteeringWheelPos> SteeringWheelPos { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<TirePurpose> TirePurposes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Width> Widths { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ad-Portal;trusted_connection=true;");
        }
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
