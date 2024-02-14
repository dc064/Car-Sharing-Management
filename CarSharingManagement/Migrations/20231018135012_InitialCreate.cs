using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSharingManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    MechanicId = table.Column<int>(type: "INTEGER", nullable: false),
                    Color = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerEmail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Seats = table.Column<int>(type: "INTEGER", nullable: false),
                    HasAirConditioner = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "Mechanics",
                columns: table => new
                {
                    MechanicId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MechanicName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanics", x => x.MechanicId);
                });

            migrationBuilder.CreateTable(
                name: "Sharings",
                columns: table => new
                {
                    SharingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    From = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    To = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sharings", x => x.SharingId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Mechanics");

            migrationBuilder.DropTable(
                name: "Sharings");
        }
    }
}
