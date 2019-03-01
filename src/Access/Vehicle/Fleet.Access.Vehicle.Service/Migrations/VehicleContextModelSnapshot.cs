﻿// <auto-generated />
using System;
using Fleet.Access.Vehicle.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Fleet.Access.Vehicle.Service.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Fleet.Access.Vehicle.Service.Entities.VehicleActivitySourceStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<string>("FleetId");

                    b.Property<int>("PartnerId");

                    b.Property<string>("Status");

                    b.Property<string>("TransactionId");

                    b.HasKey("Id");

                    b.ToTable("VehicleActivitySources");
                });

            modelBuilder.Entity("Fleet.Access.Vehicle.Service.Entities.VehicleActivityStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<double>("Odometer");

                    b.Property<string>("OdometerUnits");

                    b.Property<int>("PartnerId");

                    b.Property<string>("PrimaryMemberId");

                    b.Property<int>("SourceId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("VehicleId");

                    b.Property<int>("VehiclePeriodId");

                    b.HasKey("Id");

                    b.ToTable("VehicleActivities");
                });

            modelBuilder.Entity("Fleet.Access.Vehicle.Service.Entities.VehicleStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("PartnerId");

                    b.Property<string>("PartnerVehicleId");

                    b.Property<string>("PlateNumber");

                    b.Property<string>("VehicleId");

                    b.Property<string>("Vin");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}