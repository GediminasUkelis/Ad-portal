using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<Defects> Defects { get; set; }
        public DbSet<Diameter> Diameters { get; set; }
        public DbSet<Doors> Doors { get; set; }
        public DbSet<Features> Features { get; set; }
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
        public DbSet<MotorbikeFeatures> MotorbikeFeatures { get; set; }
        public DbSet<CarFeatures> CarFeatures { get; set; }
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
            modelBuilder.Entity<CarFeatures>()
              .HasKey(bc => new { bc.CarId, bc.FeatureId });
            modelBuilder.Entity<CarFeatures>()
                .HasOne(bc => bc.Car)
                .WithMany(b => b.CarFeatures)
                .HasForeignKey(bc => bc.CarId);
            modelBuilder.Entity<CarFeatures>()
                .HasOne(bc => bc.Feature)
                .WithMany(c => c.CarFeatures)
                .HasForeignKey(bc => bc.FeatureId);

            modelBuilder.Entity<MotorbikeFeatures>()
              .HasKey(bc => new { bc.MotorbikeId, bc.FeatureId });
            modelBuilder.Entity<MotorbikeFeatures>()
                .HasOne(bc => bc.Motorbike)
                .WithMany(b => b.MotorbikeFeatures)
                .HasForeignKey(bc => bc.MotorbikeId);
            modelBuilder.Entity<MotorbikeFeatures>()
                .HasOne(bc => bc.Feature)
                .WithMany(c => c.MotorbikeFeatures)
                .HasForeignKey(bc => bc.FeatureId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
