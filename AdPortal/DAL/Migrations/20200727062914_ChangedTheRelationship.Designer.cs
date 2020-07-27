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
    [Migration("20200727062914_ChangedTheRelationship")]
    partial class ChangedTheRelationship
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
                            Id = new Guid("561718c7-a554-4e58-828f-0bb9490694d2"),
                            Name = "Automobilis"
                        },
                        new
                        {
                            Id = new Guid("72a8f2d1-a82e-4234-9418-b215c3fae451"),
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
                            Id = new Guid("1c207fcc-55f0-4d66-90bc-a7975d169654"),
                            Name = "Balta"
                        },
                        new
                        {
                            Id = new Guid("ff1b7331-f97a-4c2c-979e-2aefb0e0c765"),
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
                            Id = new Guid("ff2bbd22-3ac5-44a6-a43b-a5791f1be29a"),
                            VehicCondition = "Naudota"
                        },
                        new
                        {
                            Id = new Guid("b423a103-28af-4461-ba48-e8481e324d0f"),
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
                            Id = new Guid("edfaf6a4-3a5e-4cbf-9ec5-f2699e8245b1"),
                            CoolingType = "Oru"
                        },
                        new
                        {
                            Id = new Guid("e1c021ba-8655-4b6d-8270-ef23913fb233"),
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
                            Id = new Guid("a3417e17-46c4-4785-8f1a-b44c69f9d816"),
                            Defect = "Be defetkų"
                        },
                        new
                        {
                            Id = new Guid("2148286f-93f9-4bfd-abaf-27f24dc11aef"),
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
                            Id = new Guid("e113a10b-2b27-41a1-9d02-b454b4984804"),
                            TireDiameter = 17m
                        },
                        new
                        {
                            Id = new Guid("461201d6-a303-41d1-9342-4c4484dd9138"),
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
                            Id = new Guid("b9a0b9f7-94b8-42f1-b69e-e0bf8fd7ea24"),
                            DoorCount = "4/5"
                        },
                        new
                        {
                            Id = new Guid("3043ecc5-53be-4e75-9b4f-966a4e65e0ad"),
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
                            Id = new Guid("306543ce-ba1b-4b34-827f-2e34185b31e7"),
                            Type = "Universalas"
                        },
                        new
                        {
                            Id = new Guid("3866ba2e-1062-4c0b-90eb-e06f38a8ff83"),
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
                            Id = new Guid("b999dd2d-d2eb-41f4-a52d-30498355e4d1"),
                            Type = "Benzinas"
                        },
                        new
                        {
                            Id = new Guid("9e9609cc-7af9-455d-9c76-bfa6c1f06c9c"),
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
                            Id = new Guid("34177ec1-3722-494f-9d0e-c01275be6052"),
                            TireHeight = 205m
                        },
                        new
                        {
                            Id = new Guid("3dc42c9d-22aa-4047-b0b3-87a50c0fb8a5"),
                            TireHeight = 215m
                        });
                });

            modelBuilder.Entity("Domain.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bytes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarsId");

                    b.ToTable("Images");
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
                            Id = new Guid("9369b9a9-a570-44b7-9d0c-ce39d911952a"),
                            Name = "RS6"
                        },
                        new
                        {
                            Id = new Guid("f62f9714-b3b4-4b38-bf64-a258d9d343c2"),
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
                            Id = new Guid("ec625ecb-b0c3-427f-96de-0bb0228ddb0c"),
                            Position = "Kairė"
                        },
                        new
                        {
                            Id = new Guid("61e45246-19d5-4f8f-be1d-aae23c6a5cd8"),
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
                            Id = new Guid("c032d083-ae4c-4e98-acca-fd355f701699"),
                            Type = "Automatinė"
                        },
                        new
                        {
                            Id = new Guid("7f52790d-0a38-4997-a7eb-5103dc1cf411"),
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
                });

            modelBuilder.Entity("Domain.Models.Image", b =>
                {
                    b.HasOne("Domain.Models.Car", "Cars")
                        .WithMany("Image")
                        .HasForeignKey("CarsId");
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
