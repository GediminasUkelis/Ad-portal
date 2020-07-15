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
                            Id = new Guid("bef04355-916a-49de-be7b-165631ebb2e4"),
                            Name = "Automobilis"
                        },
                        new
                        {
                            Id = new Guid("9ef8410f-ca8f-454e-9492-ba1bef2524c4"),
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
                            Id = new Guid("c6d03134-c9f1-4261-98cf-d40d508aec95"),
                            Name = "Balta"
                        },
                        new
                        {
                            Id = new Guid("5cdc527c-4d74-4c8c-a25e-f12a37b48073"),
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
                            Id = new Guid("249463ae-3848-4467-a827-14b5f488d2c7"),
                            VehicCondition = "Naudota"
                        },
                        new
                        {
                            Id = new Guid("62047d99-9f85-4818-a15d-08105e1dcdd2"),
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
                            Id = new Guid("ee488584-30b5-4d32-a194-99b09748f303"),
                            CoolingType = "Oru"
                        },
                        new
                        {
                            Id = new Guid("c4eb2da0-1ecb-4d53-af86-21b9ab0d43f3"),
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
                            Id = new Guid("f96512f0-9a63-466c-994b-d5c45e6bacbf"),
                            Defect = "Be defetkų"
                        },
                        new
                        {
                            Id = new Guid("9210d40f-63c7-410e-bc2d-64544713268d"),
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
                            Id = new Guid("8adba2f7-9eaf-49d6-ae40-52a292c60c35"),
                            TireDiameter = 17m
                        },
                        new
                        {
                            Id = new Guid("9728b7a3-9a78-4be6-ace4-f97d352e4a85"),
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
                            Id = new Guid("c2ba25e0-8355-433a-aeb8-e5f2187df256"),
                            DoorCount = "4/5"
                        },
                        new
                        {
                            Id = new Guid("527b5b11-15bd-4485-9fe2-a828450513b3"),
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
                            Id = new Guid("d63af71c-07e6-4ea2-a65a-394622f641f1"),
                            Type = "Universalas"
                        },
                        new
                        {
                            Id = new Guid("7e3585f1-364e-40a6-a91e-2dbe0b1ca9f7"),
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
                            Id = new Guid("d895c741-a4d9-4849-8dc5-00df53062280"),
                            Type = "Benzinas"
                        },
                        new
                        {
                            Id = new Guid("1275452f-3fc8-4116-9810-f526734788a2"),
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
                            Id = new Guid("2e77e556-aa90-475f-8b6a-986628061c67"),
                            TireHeight = 205m
                        },
                        new
                        {
                            Id = new Guid("301a8bf7-8955-4c01-82ec-9c29989a893d"),
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
                            Id = new Guid("31b9b9ec-0bc9-4c10-a424-4b66f5421916"),
                            Name = "RS6"
                        },
                        new
                        {
                            Id = new Guid("1473bc09-81e6-445b-ab6d-371a7a2ec805"),
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
                            Id = new Guid("6be13bcc-be8e-4364-950d-90a651cb85db"),
                            Position = "Kairė"
                        },
                        new
                        {
                            Id = new Guid("2e1b4709-5c29-4664-abf6-949a1174c697"),
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
                            Id = new Guid("5bf58662-c8d9-4ff5-a46d-81ada8a250a3"),
                            Type = "Automatinė"
                        },
                        new
                        {
                            Id = new Guid("f8f427da-6123-40cc-91a7-1c20aa05b44c"),
                            Type = "Mechaninė"
                        });
                });

            modelBuilder.Entity("Domain.Models.VehicleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

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

            modelBuilder.Entity("Domain.Models.VehicleType", b =>
                {
                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
