using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFAConsultant.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_aboutus",
                columns: new[] { "Id", "Description", "Success_Rate", "Title", "Total_Team_Members", "Total_Visa_Categories", "Total_Visa_Processes" },
                values: new object[] { 1, "This is description", 100, "ABOUT1", 21, 31, 2000 });

            migrationBuilder.InsertData(
                table: "tbl_contactus",
                columns: new[] { "Id", "Address1", "Address2", "Email1", "Email2", "FacebookLink", "InstagramLink", "PhoneNumber1", "PhoneNumber2", "TiktokLink", "TwitterLink" },
                values: new object[] { 1, "Kotli", "kotli", "naseer@gmail.com", "insram@gmail.com", "facebook.com", "instagram.com", "12345", "12345", "tiktok.com", "twitter.com" });

            migrationBuilder.InsertData(
                table: "tbl_countries",
                columns: new[] { "Id", "Country_PicUrl", "Flag_PicUrl", "Name" },
                values: new object[] { 1, "image.jpg", "image.jpg", "United Kingdom" });

            migrationBuilder.InsertData(
                table: "tbl_professionals",
                columns: new[] { "Id", "Description", "Email", "Name", "PhoneNumber", "PicUrl" },
                values: new object[] { 1, "This is Muhammad Naseer", "naseer@gmail.com", "Naseer", "12345", "image.jpg" });

            migrationBuilder.InsertData(
                table: "tbl_querymessages",
                columns: new[] { "Id", "Email", "Message", "Name", "PhoneNumber", "Subject" },
                values: new object[] { 1, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" });

            migrationBuilder.InsertData(
                table: "tbl_review",
                columns: new[] { "Id", "Designation", "Message", "Name", "PicUrl", "Rating" },
                values: new object[] { 1, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 });

            migrationBuilder.InsertData(
                table: "tbl_settings",
                columns: new[] { "Id", "LogoFavicon", "Name" },
                values: new object[] { 1, "image.jpg", "AFAConsultant" });

            migrationBuilder.InsertData(
                table: "tbl_slider",
                columns: new[] { "Id", "Description", "PicURL", "Title" },
                values: new object[] { 1, "This is Slider", "image.jpg", "Slider" });

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "Id", "FullName", "ImageName", "Password", "Username" },
                values: new object[] { 1, "Muhammad Naseer", null, "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_aboutus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_contactus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_professionals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_querymessages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_review",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_settings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_slider",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
