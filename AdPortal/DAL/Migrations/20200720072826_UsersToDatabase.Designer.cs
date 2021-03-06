﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200720072826_UsersToDatabase")]
    partial class UsersToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Cars");
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
                            Id = new Guid("b7b433ca-bcef-4e6b-843c-57691d2663c5"),
                            Name = "Automobilis"
                        },
                        new
                        {
                            Id = new Guid("1d8eb3e2-5a2a-4cc6-9e49-0de530a18aa8"),
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
                            Id = new Guid("4614c6ba-ed02-4bd0-9534-c01e98182666"),
                            Name = "Balta"
                        },
                        new
                        {
                            Id = new Guid("05a712a4-d682-4b2b-8db3-91874b4fda58"),
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
                            Id = new Guid("2e8256d7-afe5-4161-812f-ef66e6f94997"),
                            VehicCondition = "Naudota"
                        },
                        new
                        {
                            Id = new Guid("eaf5b012-fefc-4e40-8534-75809c211e33"),
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
                            Id = new Guid("ebe33cde-2c25-433f-9200-5b3489e62bf1"),
                            CoolingType = "Oru"
                        },
                        new
                        {
                            Id = new Guid("53812453-0de5-4b4c-985b-b161e557951d"),
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
                            Id = new Guid("cb8acbd3-d09d-49c9-909e-27c399c7b30b"),
                            Defect = "Be defetkų"
                        },
                        new
                        {
                            Id = new Guid("c146f288-0085-49ca-a43d-15e4638b3d61"),
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
                            Id = new Guid("08ee46f2-7b32-4b3a-a7f5-2a5e1c4ba733"),
                            TireDiameter = 17m
                        },
                        new
                        {
                            Id = new Guid("ce46390f-6477-4f30-9f95-ae211c31202e"),
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
                            Id = new Guid("7d01dbf7-233f-435d-a6ef-73bf50c69aad"),
                            DoorCount = "4/5"
                        },
                        new
                        {
                            Id = new Guid("040ff127-2655-490a-8d02-014b4da67f53"),
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
                            Id = new Guid("42d814c5-b6e2-48be-beea-4affb2c28dc1"),
                            Type = "Universalas"
                        },
                        new
                        {
                            Id = new Guid("0d23e388-418f-4b52-966e-796f903b6e7e"),
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
                            Id = new Guid("88a3f009-d21b-4c2c-a92e-19643b992015"),
                            Type = "Benzinas"
                        },
                        new
                        {
                            Id = new Guid("7b5118a2-4e4a-4660-8b04-cc9e1bd04d62"),
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
                            Id = new Guid("2df9f80c-3207-47c4-ad7c-f078c9a8eec8"),
                            TireHeight = 205m
                        },
                        new
                        {
                            Id = new Guid("c7fac864-3670-4db6-90a1-f3deec955a90"),
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
                            Id = new Guid("12fd3b39-7d20-47f8-b848-5af9fe224b20"),
                            Name = "RS6"
                        },
                        new
                        {
                            Id = new Guid("9e9dfa28-6410-4993-95db-486b993e3261"),
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

                    b.Property<Guid?>("VehicleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ConditionId");

                    b.HasIndex("CoolingId");

                    b.HasIndex("DefectsId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Motorbikes");
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
                            Id = new Guid("7268e743-12c9-4a9d-b896-f781485f28c8"),
                            Position = "Kairė"
                        },
                        new
                        {
                            Id = new Guid("6bf12030-bd07-47ab-bbf9-53fb8b4c27be"),
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

                    b.Property<Guid?>("WidthId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("DiameterId");

                    b.HasIndex("HeightId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TirePurposeId");

                    b.HasIndex("WidthId");

                    b.ToTable("Tires");
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
                            Id = new Guid("96a17649-7df1-4c4f-a7b4-c5199b13871f"),
                            Type = "Automatinė"
                        },
                        new
                        {
                            Id = new Guid("288dbe82-41e5-4894-bd65-4226b020e084"),
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

                    b.HasOne("Domain.Models.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId");
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

                    b.HasOne("Domain.Models.Width", "Width")
                        .WithMany()
                        .HasForeignKey("WidthId");
                });
#pragma warning restore 612, 618
        }
    }
}
