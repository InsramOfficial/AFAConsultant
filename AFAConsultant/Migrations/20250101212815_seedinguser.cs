using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFAConsultant.Migrations
{
    public partial class seedinguser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "Id", "FullName", "ImageName", "Password", "Username" },
                values: new object[] { 2, "Muhammad Naseer", "naseer.jpg", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
