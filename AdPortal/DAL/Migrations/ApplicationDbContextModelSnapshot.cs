﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DefectsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DoorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FrameTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FuelTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ManufacturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ManufacturerModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<Guid?>("SteeringWheelPosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TransmissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("VehicleInspection")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DefectsId");

                    b.HasIndex("DoorsId");

                    b.HasIndex("FrameTypeId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ManufacturerModelId");

                    b.HasIndex("SteeringWheelPosId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Domain.Models.CarImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarImages");
                });

            modelBuilder.Entity("Domain.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5498def1-1ca3-42c9-bfe1-64019412bc49"),
                            Name = "Automobilis"
                        },
                        new
                        {
                            Id = new Guid("24f5190a-b8cd-494a-a750-a7ac2da0d7d1"),
                            Name = "Motociklas"
                        });
                });

            modelBuilder.Entity("Domain.Models.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("14fcd99c-3593-40be-b132-5465c9edefaf"),
                            Name = "Balta"
                        },
                        new
                        {
                            Id = new Guid("d88635dc-678d-4700-8340-83eaab0b7a84"),
                            Name = "Juoda"
                        });
                });

            modelBuilder.Entity("Domain.Models.Condition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VehicCondition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87d02b16-711e-408c-9c46-028deb30c505"),
                            VehicCondition = "Naudota"
                        },
                        new
                        {
                            Id = new Guid("8c9aadf1-76d1-42c4-bf12-7f4203f6f348"),
                            VehicCondition = "Nauja"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cooling", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoolingType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coolings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15ffe8aa-2b9a-4106-a09b-5be4d1ff145d"),
                            CoolingType = "Oru"
                        },
                        new
                        {
                            Id = new Guid("4edb5c1b-f59a-4247-9edd-12825e8c9280"),
                            CoolingType = "Vandeniu"
                        });
                });

            modelBuilder.Entity("Domain.Models.Defects", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Defect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Defects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("46e32ac2-1470-4cbf-bccf-bcd30de9707b"),
                            Defect = "Be defetkų"
                        },
                        new
                        {
                            Id = new Guid("cb4c8b85-7ee8-4e27-8a0f-9e0854a5eace"),
                            Defect = "Degęs"
                        });
                });

            modelBuilder.Entity("Domain.Models.Diameter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TireDiameter")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Diameters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92d169fb-19b6-4725-902c-55512ea2a5b9"),
                            TireDiameter = 17m
                        },
                        new
                        {
                            Id = new Guid("f4eddc26-d1bc-495e-a3a5-597d7b3c58dd"),
                            TireDiameter = 18m
                        });
                });

            modelBuilder.Entity("Domain.Models.Doors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DoorCount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93cb3b17-8b07-4a8f-9cd4-eafbfd23bc21"),
                            DoorCount = "4/5"
                        },
                        new
                        {
                            Id = new Guid("ba9dfc3a-4478-4536-95b1-e5135c2d3060"),
                            DoorCount = "2/3"
                        });
                });

            modelBuilder.Entity("Domain.Models.FrameType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FrameTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d53e8e3-3dab-4e94-ab7a-57c1cee47c8f"),
                            Type = "Universalas"
                        },
                        new
                        {
                            Id = new Guid("3f78b537-7d01-4bde-bfdc-81d62bfcfc68"),
                            Type = "Sedanas"
                        });
                });

            modelBuilder.Entity("Domain.Models.FuelType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8700eacf-bb3c-42f4-9c76-40708bdf2af7"),
                            Type = "Benzinas"
                        },
                        new
                        {
                            Id = new Guid("adb92f27-86d5-4ad2-a8da-fee07844bf22"),
                            Type = "Dyzelinas"
                        });
                });

            modelBuilder.Entity("Domain.Models.Height", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TireHeight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Heights");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd10d612-fcbd-4df0-8c86-f46f7e4ce19e"),
                            TireHeight = 205m
                        },
                        new
                        {
                            Id = new Guid("95f0b057-15d6-43bc-ac0c-289a717f995c"),
                            TireHeight = 215m
                        });
                });

            modelBuilder.Entity("Domain.Models.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Domain.Models.ManufacturerModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ManufacturerModels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6a9907d-12b7-403d-8eec-df80d56d623d"),
                            Name = "RS6"
                        },
                        new
                        {
                            Id = new Guid("a57722b2-e538-47bd-b712-e5a38bb5035d"),
                            Name = "E60"
                        });
                });

            modelBuilder.Entity("Domain.Models.Motorbike", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CoolingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DefectsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<Guid?>("FuelTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ManufacturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Registration")
                        .HasColumnType("bit");

                    b.Property<decimal>("TireWearOut")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VehicleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ConditionId");

                    b.HasIndex("CoolingId");

                    b.HasIndex("DefectsId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Motorbikes");
                });

            modelBuilder.Entity("Domain.Models.MotorbikeImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MotorbikeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MotorbikeId");

                    b.ToTable("MotorbikeImages");
                });

            modelBuilder.Entity("Domain.Models.Season", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SeasonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Domain.Models.SteeringWheelPos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SteeringWheelPos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e2a17a0-5f03-45a7-97ef-a710a35547e8"),
                            Position = "Kairė"
                        },
                        new
                        {
                            Id = new Guid("90011866-1c58-4c40-aaed-ded1114e6d9c"),
                            Position = "Dešinė"
                        });
                });

            modelBuilder.Entity("Domain.Models.Tire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DiameterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HeightId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ManufacturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TirePurposeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TireWearOut")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WidthId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("DiameterId");

                    b.HasIndex("HeightId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TirePurposeId");

                    b.HasIndex("UserId");

                    b.HasIndex("WidthId");

                    b.ToTable("Tires");
                });

            modelBuilder.Entity("Domain.Models.TireImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TireId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TireId");

                    b.ToTable("TireImages");
                });

            modelBuilder.Entity("Domain.Models.TirePurpose", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TirePurposes");
                });

            modelBuilder.Entity("Domain.Models.Transmission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2012170e-9df6-4aef-9652-3180fec0df5b"),
                            Type = "Automatinė"
                        },
                        new
                        {
                            Id = new Guid("373e19e0-5c4e-48ad-b6e8-f5b240b4359f"),
                            Type = "Mechaninė"
                        });
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.VehicleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Domain.Models.Width", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TireWidth")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Widths");
                });

            modelBuilder.Entity("Domain.Models.Car", b =>
                {
                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Domain.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Domain.Models.Defects", "Defects")
                        .WithMany()
                        .HasForeignKey("DefectsId");

                    b.HasOne("Domain.Models.Doors", "Doors")
                        .WithMany()
                        .HasForeignKey("DoorsId");

                    b.HasOne("Domain.Models.FrameType", "FrameType")
                        .WithMany()
                        .HasForeignKey("FrameTypeId");

                    b.HasOne("Domain.Models.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId");

                    b.HasOne("Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Domain.Models.ManufacturerModel", "ManufacturerModel")
                        .WithMany()
                        .HasForeignKey("ManufacturerModelId");

                    b.HasOne("Domain.Models.SteeringWheelPos", "SteeringWheelPos")
                        .WithMany()
                        .HasForeignKey("SteeringWheelPosId");

                    b.HasOne("Domain.Models.Transmission", "Transmission")
                        .WithMany()
                        .HasForeignKey("TransmissionId");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.CarImage", b =>
                {
                    b.HasOne("Domain.Models.Car", "Cars")
                        .WithMany("Image")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Motorbike", b =>
                {
                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Domain.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId");

                    b.HasOne("Domain.Models.Cooling", "Cooling")
                        .WithMany()
                        .HasForeignKey("CoolingId");

                    b.HasOne("Domain.Models.Defects", "Defects")
                        .WithMany()
                        .HasForeignKey("DefectsId");

                    b.HasOne("Domain.Models.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId");

                    b.HasOne("Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Motorbikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId");
                });

            modelBuilder.Entity("Domain.Models.MotorbikeImage", b =>
                {
                    b.HasOne("Domain.Models.Motorbike", "Motorbikes")
                        .WithMany("Image")
                        .HasForeignKey("MotorbikeId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Tire", b =>
                {
                    b.HasOne("Domain.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId");

                    b.HasOne("Domain.Models.Diameter", "Diameter")
                        .WithMany()
                        .HasForeignKey("DiameterId");

                    b.HasOne("Domain.Models.Height", "Height")
                        .WithMany()
                        .HasForeignKey("HeightId");

                    b.HasOne("Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Domain.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId");

                    b.HasOne("Domain.Models.TirePurpose", "TirePurpose")
                        .WithMany()
                        .HasForeignKey("TirePurposeId");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Tires")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Width", "Width")
                        .WithMany()
                        .HasForeignKey("WidthId");
                });

            modelBuilder.Entity("Domain.Models.TireImage", b =>
                {
                    b.HasOne("Domain.Models.Tire", "Tires")
                        .WithMany("Image")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
