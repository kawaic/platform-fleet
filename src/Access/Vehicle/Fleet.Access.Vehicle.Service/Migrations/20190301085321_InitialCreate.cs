using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Fleet.Access.Vehicle.Service.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleActivities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PrimaryMemberId = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Odometer = table.Column<double>(nullable: false),
                    PartnerId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    VehiclePeriodId = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false),
                    OdometerUnits = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleActivitySources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<string>(nullable: true),
                    Data = table.Column<string>(type: "jsonb", nullable: true),
                    FleetId = table.Column<string>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleActivitySources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Vin = table.Column<string>(nullable: true),
                    VehicleId = table.Column<string>(nullable: true),
                    PlateNumber = table.Column<string>(nullable: true),
                    PartnerId = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    PartnerVehicleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleActivities");

            migrationBuilder.DropTable(
                name: "VehicleActivitySources");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
