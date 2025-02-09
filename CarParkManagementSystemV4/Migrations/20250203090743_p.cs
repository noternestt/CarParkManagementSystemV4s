using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class p : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d1e6515-b6ab-4154-a135-ddf675c41121", "AQAAAAIAAYagAAAAEMB6zyKNG+XDaJTbzXauj+TV5p3RQsYvHNLkchgLIgk4EKDkZd6MfLTCfxGEKa0upQ==", "3b3b52df-7fe4-4395-99f4-629bd64aac0f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed8ad04-a496-4671-8208-17d2b2bca514", "AQAAAAIAAYagAAAAEODbOQFp04flqJLcach4qs/9r8ygrg2OLbiRBV0zT0nFM0VHop+kK1TTrU7Cqq6rhg==", "e27fd09e-1ae7-4913-8ded-4555655b2c44" });
        }
    }
}
