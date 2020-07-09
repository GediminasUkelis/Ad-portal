using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Contracts;

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
            //modelBuilder.Entity<Car>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = DateTime.Now,
                    Name = "Automobilis"
                },
            new Category()
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Name = "Motociklas"
            }
            );
            modelBuilder.Entity<Color>().HasData(
                new Color()
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = DateTime.Now,
                    Name = "Balta"
                },
            new Color()
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Name = "Juoda"
            }
            );
            modelBuilder.Entity<Condition>().HasData(
               new Condition()
               {
                   Id = Guid.NewGuid(),
                   CreatedOn = DateTime.Now,
                   VehicCondition = "Naudota"
               },
           new Condition()
           {
               Id = Guid.NewGuid(),
               CreatedOn = DateTime.Now,
               VehicCondition = "Nauja"
           }
           );
            modelBuilder.Entity<Cooling>().HasData(
              new Cooling()
              {
                  Id = Guid.NewGuid(),
                  CreatedOn = DateTime.Now,
                  CoolingType = "Oru"

              },
          new Cooling()
          {
              Id = Guid.NewGuid(),
              CreatedOn = DateTime.Now,
              CoolingType = "Vandeniu"
          }
          );
            modelBuilder.Entity<Defects>().HasData(
              new Defects()
              {
                  Id = Guid.NewGuid(),
                  CreatedOn = DateTime.Now,
                  Defect = "Be defetkų"

              },
          new Defects()
          {
              Id = Guid.NewGuid(),
              CreatedOn = DateTime.Now,
              Defect = "Degęs"
          }
          );
            modelBuilder.Entity<Diameter>().HasData(
              new Diameter()
              {
                  Id = Guid.NewGuid(),
                  CreatedOn = DateTime.Now,
                  TireDiameter = 17

              },
          new Diameter()
          {
              Id = Guid.NewGuid(),
              CreatedOn = DateTime.Now,
              TireDiameter = 18
          }
          );
            modelBuilder.Entity<Doors>().HasData(
           new Doors()
           {
               Id = Guid.NewGuid(),
               CreatedOn = DateTime.Now,
               DoorCount = "4/5"

           },
       new Doors()
       {
           Id = Guid.NewGuid(),
           CreatedOn = DateTime.Now,
           DoorCount = "2/3"
       }
       );
            modelBuilder.Entity<FrameType>().HasData(
          new FrameType()
          {
              Id = Guid.NewGuid(),
              CreatedOn = DateTime.Now,
              Type = "Universalas"

          },
      new FrameType()
      {
          Id = Guid.NewGuid(),
          CreatedOn = DateTime.Now,
          Type = "Sedanas"
      }
      );
            modelBuilder.Entity<FuelType>().HasData(
        new FuelType()
        {
            Id = Guid.NewGuid(),
            CreatedOn = DateTime.Now,
            Type = "Benzinas"

        },
    new FuelType()
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTime.Now,
        Type = "Dyzelinas"
    }
    );
            modelBuilder.Entity<Height>().HasData(
  new Height()
  {
      Id = Guid.NewGuid(),
      CreatedOn = DateTime.Now,
      TireHeight = 205

  },
  new Height()
  {
      Id = Guid.NewGuid(),
      CreatedOn = DateTime.Now,
      TireHeight = 215
  }
  );



            modelBuilder.Entity<SteeringWheelPos>().HasData(
         new SteeringWheelPos()
         {
             Id = Guid.NewGuid(),
             CreatedOn = DateTime.Now,
             Position = "Kairė"

         },
         new SteeringWheelPos()
         {
             Id = Guid.NewGuid(),
             CreatedOn = DateTime.Now,
             Position = "Dešinė"
         });

            modelBuilder.Entity<Transmission>().HasData(
           new Transmission()
           {
               Id = Guid.NewGuid(),
               CreatedOn = DateTime.Now,
               Type = "Automatinė"

           },
           new Transmission()
           {
               Id = Guid.NewGuid(),
               CreatedOn = DateTime.Now,
               Type = "Mechaninė"
           });
            modelBuilder.Entity<ManufacturerModel>().HasData(
           new ManufacturerModel()
           {

               CreatedOn = DateTime.Now,
               Name = "RS6"

           },
           new ManufacturerModel()
           {

               CreatedOn = DateTime.Now,
               Name = "E60"

           });

            base.OnModelCreating(modelBuilder);
        }
    }
}
