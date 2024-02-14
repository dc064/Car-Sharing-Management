using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSharingManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MechanicSurname",
                table: "Mechanics",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Equipments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerSurname",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MechanicSurname",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "CustomerSurname",
                table: "Customers");
        }
    }
}
