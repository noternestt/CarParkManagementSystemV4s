using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class VisitedLocationsz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552e19ba-acaa-47dc-8c61-7fba07b5b44b", "AQAAAAIAAYagAAAAEBkqquhsPqwkBpo8fMc+da2RUTpNEo1bRy2H/hWoVEvbsLMnkxnr1pTzD70LXwFebQ==", "27f99906-fdf3-4f60-82ec-81e1136ee9d7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c1e1e26-f5ca-4819-bf9a-3b1666a354e1", "AQAAAAIAAYagAAAAEP+KGO7BfLqpygiazc+/7pm8Nn4zRmPM7kioWEqhCbm5NprONx0BUri9Rg/AsIMYlQ==", "a3d35f07-5256-4f27-ac5c-9a1daf04b0be" });
        }
    }
}
