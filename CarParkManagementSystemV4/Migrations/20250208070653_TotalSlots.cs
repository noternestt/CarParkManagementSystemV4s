using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class TotalSlots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSlots",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8ed863-3dd8-4c17-a065-85621f1e21ba", "AQAAAAIAAYagAAAAEGMY+A3oOw/0wA20K+s6VN9Vp8Y1SFpjS/n73zJKOxaGqoAiXEaIt0J2Kn/Wfk42dA==", "a70b951f-fac8-4c7b-a2e6-29a4cc7d93aa" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalSlots",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalSlots",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalSlots",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalSlots",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalSlots",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalSlots",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSlots",
                table: "Location");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552e19ba-acaa-47dc-8c61-7fba07b5b44b", "AQAAAAIAAYagAAAAEBkqquhsPqwkBpo8fMc+da2RUTpNEo1bRy2H/hWoVEvbsLMnkxnr1pTzD70LXwFebQ==", "27f99906-fdf3-4f60-82ec-81e1136ee9d7" });
        }
    }
}
