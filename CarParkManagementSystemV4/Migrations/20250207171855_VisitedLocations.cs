using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class VisitedLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c1e1e26-f5ca-4819-bf9a-3b1666a354e1", "AQAAAAIAAYagAAAAEP+KGO7BfLqpygiazc+/7pm8Nn4zRmPM7kioWEqhCbm5NprONx0BUri9Rg/AsIMYlQ==", "a3d35f07-5256-4f27-ac5c-9a1daf04b0be" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eb4e058-74a3-4f85-92c4-8291c7572789", "AQAAAAIAAYagAAAAECRVdvhcm0FKDcg22TTRm8MdkRfMqXDJnqM/B022dridvJDNxEYqKngc8FqV+ylqBw==", "b3c01dc6-3ef2-4f85-9702-02090a00141d" });
        }
    }
}
