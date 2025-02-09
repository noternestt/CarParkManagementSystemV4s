using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class re : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b57610a-bb57-4de3-85e1-421d9ea88ddb", "AQAAAAIAAYagAAAAEBauem9TnSQ/qnnNn0TaBC9jgeoMtuRpkLdeIPdb2jBnazYCy4L+TpnN5Fw5Ut9VFg==", "8dc11e6e-94a5-40f1-ad02-3b81140aa36b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d1e6515-b6ab-4154-a135-ddf675c41121", "AQAAAAIAAYagAAAAEMB6zyKNG+XDaJTbzXauj+TV5p3RQsYvHNLkchgLIgk4EKDkZd6MfLTCfxGEKa0upQ==", "3b3b52df-7fe4-4395-99f4-629bd64aac0f" });
        }
    }
}
