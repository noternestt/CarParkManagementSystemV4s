using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedParkingSessionStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ParkingSession",
                nullable: true,
                defaultValue: "Pending"); // Ensure default value is "Pending"

            // Update existing records to "Pending" if NULL
            migrationBuilder.Sql("UPDATE ParkingSession SET Status = 'Pending' WHERE Status IS NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ParkingSession",
                nullable: true,
                defaultValue: null);
        }

    }
}
