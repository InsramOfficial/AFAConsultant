using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFAConsultant.Migrations
{
    public partial class reviewseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_review",
                columns: new[] { "Id", "Designation", "Message", "Name", "PicUrl", "Rating" },
                values: new object[,]
                {
                    { 2, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 3, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 4, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 5, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 6, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
