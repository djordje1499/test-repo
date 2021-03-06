// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PharmacyClassLib;

namespace PharmacyAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PharmacyClassLib.Model.Medication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PotentialDangers")
                        .HasColumnType("text");

                    b.Property<string>("Precautions")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Usage")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Medications");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Manufacturer = "J&J",
                            Name = "Synthroid",
                            PotentialDangers = "None.",
                            Precautions = "None.",
                            Quantity = 150,
                            Status = 0,
                            Usage = "Taken once per day"
                        },
                        new
                        {
                            Id = 2L,
                            Manufacturer = "Merck & Co. Inc.",
                            Name = "Ventolin",
                            PotentialDangers = "Not advised for pregnant women.",
                            Precautions = "None.",
                            Quantity = 200,
                            Status = 2,
                            Usage = "Taken twice per day"
                        },
                        new
                        {
                            Id = 3L,
                            Manufacturer = "Pfizer Inc.",
                            Name = "Januvia",
                            PotentialDangers = "Not advised for children.",
                            Precautions = "None.",
                            Quantity = 750,
                            Status = 0,
                            Usage = "Taken once once every 5 hours"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.MedicationIngredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("MedicationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MedicationId");

                    b.ToTable("MedicationIngredients");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Vitamin C"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Phosphorus"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Calcium"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DurationEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DurationStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Objection", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HopsitalName")
                        .HasColumnType("text");

                    b.Property<long>("ObjectionIdFromHospitalDatabase")
                        .HasColumnType("bigint");

                    b.Property<string>("TextObjection")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Objection");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            HopsitalName = "Ne valja nista",
                            ObjectionIdFromHospitalDatabase = 0L,
                            TextObjection = "Bolnica1"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Pharmacy", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("AdressNumber")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pharmacies");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Adress = "Rumenačka",
                            AdressNumber = "15",
                            City = "Novi Sad",
                            Name = "Janković"
                        },
                        new
                        {
                            Id = 2L,
                            Adress = "Bulevar oslobođenja",
                            AdressNumber = "135",
                            City = "Novi Sad",
                            Name = "Janković"
                        },
                        new
                        {
                            Id = 3L,
                            Adress = "Olge Jovanović",
                            AdressNumber = "18a",
                            City = "Beograd",
                            Name = "Janković"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.RegisteredHospital", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("ApiKey")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("RegistratedHospitals");

                    b.HasData(
                        new
                        {
                            Name = "Bolnica1",
                            ApiKey = "fds15d4fs6",
                            Url = "http:localhost:7313"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Relations.IngredientInMedication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("IngredientID")
                        .HasColumnType("bigint");

                    b.Property<long>("MedicationID")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("IngredientInMedication");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IngredientID = 1L,
                            MedicationID = 1L
                        },
                        new
                        {
                            Id = 2L,
                            IngredientID = 2L,
                            MedicationID = 2L
                        },
                        new
                        {
                            Id = 3L,
                            IngredientID = 2L,
                            MedicationID = 1L
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Relations.InventoryLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("MedicationID")
                        .HasColumnType("bigint");

                    b.Property<long>("PharmacyID")
                        .HasColumnType("bigint");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("InventoryLog");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            MedicationID = 1L,
                            PharmacyID = 1L,
                            Quantity = 65L
                        },
                        new
                        {
                            Id = 2L,
                            MedicationID = 2L,
                            PharmacyID = 1L,
                            Quantity = 85L
                        },
                        new
                        {
                            Id = 3L,
                            MedicationID = 1L,
                            PharmacyID = 2L,
                            Quantity = 20L
                        },
                        new
                        {
                            Id = 4L,
                            MedicationID = 3L,
                            PharmacyID = 2L,
                            Quantity = 120L
                        },
                        new
                        {
                            Id = 5L,
                            MedicationID = 1L,
                            PharmacyID = 3L,
                            Quantity = 14L
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Response", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HospitalName")
                        .HasColumnType("text");

                    b.Property<long>("ObjectionIdFromHospitalDatabase")
                        .HasColumnType("bigint");

                    b.Property<string>("TextResponse")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Response");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            HospitalName = "Kleveta",
                            ObjectionIdFromHospitalDatabase = 0L,
                            TextResponse = "Bolnica1"
                        });
                });

            modelBuilder.Entity("PharmacyClassLib.Model.MedicationIngredient", b =>
                {
                    b.HasOne("PharmacyClassLib.Model.Medication", null)
                        .WithMany("MedicationIngredients")
                        .HasForeignKey("MedicationId");
                });

            modelBuilder.Entity("PharmacyClassLib.Model.Medication", b =>
                {
                    b.Navigation("MedicationIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
