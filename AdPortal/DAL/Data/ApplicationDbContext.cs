using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Contracts;

namespace DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<TireImage> TireImages { get; set; }
        public DbSet<MotorbikeImage> MotorbikeImages { get; set; }
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
            modelBuilder.Entity<Car>().HasMany(c => c.Image).WithOne(i => i.Cars).HasForeignKey(i => i.CarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Motorbike>().HasMany(c => c.Image).WithOne(i => i.Motorbikes).HasForeignKey(i => i.MotorbikeId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Tire>().HasMany(c => c.Image).WithOne(i => i.Tires).HasForeignKey(i => i.TireId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>().HasData(
                new Category() 
                {
                    Id = Guid.NewGuid(),
       
                    Name = "Automobilis"
                },
            new Category()
            {
                Id = Guid.NewGuid(),
          
                Name = "Motociklas"
            }
            );
            modelBuilder.Entity<Color>().HasData(
                new Color()
                {
                    Id = Guid.NewGuid(),
                 
                    Name = "Balta"
                },
            new Color()
            {
                Id = Guid.NewGuid(),
            
                Name = "Juoda"
            }
            );
            modelBuilder.Entity<Condition>().HasData(
               new Condition()
               {
                   Id = Guid.NewGuid(),
                  
                   VehicCondition = "Naudota"
               },
           new Condition()
           {
               Id = Guid.NewGuid(),
               
               VehicCondition = "Nauja"
           }
           );
            modelBuilder.Entity<Cooling>().HasData(
              new Cooling()
              {
                  Id = Guid.NewGuid(),
                  
                  CoolingType = "Oru"

              },
          new Cooling()
          {
              Id = Guid.NewGuid(),
              
              CoolingType = "Vandeniu"
          }
          );
            modelBuilder.Entity<Defects>().HasData(
              new Defects()
              {
                  Id = Guid.NewGuid(),
                  
                  Defect = "Be defetkų"

              },
          new Defects()
          {
              Id = Guid.NewGuid(),
              Defect = "Degęs"
          }
          );
            modelBuilder.Entity<Diameter>().HasData(
              new Diameter()
              {
                  Id = Guid.NewGuid(),
                  
                  TireDiameter = 17

              },
          new Diameter()
          {
              Id = Guid.NewGuid(),
              TireDiameter = 18
          }
          );
            modelBuilder.Entity<Doors>().HasData(
           new Doors()
           {
               Id = Guid.NewGuid(),
               DoorCount = "4/5"

           },
       new Doors()
       {
           Id = Guid.NewGuid(),
           DoorCount = "2/3"
       }
       );
            modelBuilder.Entity<FrameType>().HasData(
          new FrameType()
          {
              Id = Guid.NewGuid(),
              Type = "Universalas"

          },
      new FrameType()
      {
          Id = Guid.NewGuid(),
          Type = "Sedanas"
      }
      );
            modelBuilder.Entity<FuelType>().HasData(
        new FuelType()
        {
            Id = Guid.NewGuid(),
            Type = "Benzinas"

        },
    new FuelType()
    {
        Id = Guid.NewGuid(),
        Type = "Dyzelinas"
    }
    );
            modelBuilder.Entity<Height>().HasData(
  new Height()
  {
      Id = Guid.NewGuid(),
      TireHeight = 205

  },
  new Height()
  {
      Id = Guid.NewGuid(),
      TireHeight = 215
  }
  );



            modelBuilder.Entity<SteeringWheelPos>().HasData(
         new SteeringWheelPos()
         {
             Id = Guid.NewGuid(),
             Position = "Kairė"

         },
         new SteeringWheelPos()
         {
             Id = Guid.NewGuid(),
             Position = "Dešinė"
         });

            modelBuilder.Entity<Transmission>().HasData(
           new Transmission()
           {
               Id = Guid.NewGuid(),
               Type = "Automatinė"

           },
           new Transmission()
           {
               Id = Guid.NewGuid(),
               Type = "Mechaninė"
           });
            modelBuilder.Entity<ManufacturerModel>().HasData(
           new ManufacturerModel()
           {

               Name = "RS6"

           },
           new ManufacturerModel()
           {

               Name = "E60"

           });

            base.OnModelCreating(modelBuilder);
        }
    }
}
