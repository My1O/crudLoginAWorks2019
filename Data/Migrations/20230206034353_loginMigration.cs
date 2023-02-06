using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDloginSQLwithEntityFramework.Data.Migrations
{
    public partial class loginMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39683c74-78a2-44fc-ae09-d2cd1bdcdeff", "7adb5801-771a-43e7-9ed9-cd8ed6b6a3be", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d22dc6c-69b7-46bd-ac8f-3f5a3ccb33e2", 0, "49bc0a34-8ff0-42ea-a0a5-f827df2c7684", "ApplicationUser", "My10@gmail.com", true, false, null, "MY10@GMAIL.COM", "MY10@GMAIL.COM", "AQAAAAEAACcQAAAAEIySdO+tTUHscbaI2Sq9k/04RdloBqgtPPpaM/RQsCryaOzeYniBcPeMcpS3QZ7QdQ==", null, false, "2fdf33bd-d706-4319-a144-ab71005b5095", false, "My10@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39683c74-78a2-44fc-ae09-d2cd1bdcdeff", "1d22dc6c-69b7-46bd-ac8f-3f5a3ccb33e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39683c74-78a2-44fc-ae09-d2cd1bdcdeff", "1d22dc6c-69b7-46bd-ac8f-3f5a3ccb33e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39683c74-78a2-44fc-ae09-d2cd1bdcdeff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d22dc6c-69b7-46bd-ac8f-3f5a3ccb33e2");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
