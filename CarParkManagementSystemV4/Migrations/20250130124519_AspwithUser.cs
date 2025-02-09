using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class AspwithUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "504773fa-c30e-4009-a3b2-ad9f157b995b", "AQAAAAIAAYagAAAAECgJKYKPtz4X4plhm6jT+AsMHe/otCZhaiJJjjQlTS8Lu8tVu9AP+EcVEXi2C/0oVg==", "12aaa0a4-cd8f-4f72-bffa-f848ec87d96b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "User",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f054f1-5553-4356-a07d-0f02aebf9d98", "AQAAAAIAAYagAAAAEPJCPAsoNUeijorGFV93KVhx+Xuzd5rBMkxQtOXPin8zxtQGIO7UwIDIF+e0+E8//A==", "fce1e219-179c-408d-853a-ebe94a9a2e24" });
        }
    }
}
