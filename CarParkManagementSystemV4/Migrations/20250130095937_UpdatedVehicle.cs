using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Vehicle");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f054f1-5553-4356-a07d-0f02aebf9d98", "AQAAAAIAAYagAAAAEPJCPAsoNUeijorGFV93KVhx+Xuzd5rBMkxQtOXPin8zxtQGIO7UwIDIF+e0+E8//A==", "fce1e219-179c-408d-853a-ebe94a9a2e24" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f88a1cf-3765-4117-89fd-5bfc296cebc9", "AQAAAAIAAYagAAAAEAIWB4iHhRJ0dpnuP5XcdPAsU0kKfId907eX81Y/yyiDVrWB+GiCjYlVbU+y91N1Ww==", "cf54e78d-3c45-46dd-aa8b-63a934fa037b" });
        }
    }
}
