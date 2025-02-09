using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class q : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0bf771-15b3-4394-b60d-f704552f05ca", "AQAAAAIAAYagAAAAEFllYesZnM5k3MDq1ZfZEVKGR7mO+x99t4nkpYUG+drB3SszOJin/pz4g13WRJRafA==", "6a92ab23-3fca-43eb-8bbd-feba44df32fc" });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSession_UserId",
                table: "ParkingSession",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ParkingSession_UserId",
                table: "ParkingSession");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f1b83d8-c40f-40ee-a480-d67cc63c46bb", "AQAAAAIAAYagAAAAEEgkUBr76xDICd+Te/V0gpYbZtiei2ndP5E/PBOPv3saiiCoau+vj68GVB+jlh2c4w==", "9b75d8d3-209b-45fc-b340-739c607bb9c1" });
        }
    }
}
