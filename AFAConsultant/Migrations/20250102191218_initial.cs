using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFAConsultant.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_aboutus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    Total_Visa_Categories = table.Column<int>(type: "int", nullable: false),
                    Total_Team_Members = table.Column<int>(type: "int", nullable: false),
                    Total_Visa_Processes = table.Column<int>(type: "int", nullable: false),
                    Success_Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_aboutus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_contactus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiktokLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_contactus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag_PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    SpecializationArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_professionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_professionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_querymessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_querymessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_review", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFavicon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_slider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PicURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user", x => x.Id);
                });

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
                values: new object[,]
                {
                    { 1, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" },
                    { 2, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" },
                    { 3, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" },
                    { 4, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" }
                });

            migrationBuilder.InsertData(
                table: "tbl_review",
                columns: new[] { "Id", "Designation", "Message", "Name", "PicUrl", "Rating" },
                values: new object[,]
                {
                    { 1, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 2, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 3, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 4, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 5, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 },
                    { 6, "programmer", "Good", "Muhammad Naseer", "image.jpg", 4 }
                });

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
                values: new object[] { 1, "Muhammad Naseer", "naseer.jpg", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_aboutus");

            migrationBuilder.DropTable(
                name: "tbl_contactus");

            migrationBuilder.DropTable(
                name: "tbl_countries");

            migrationBuilder.DropTable(
                name: "tbl_job");

            migrationBuilder.DropTable(
                name: "tbl_professionals");

            migrationBuilder.DropTable(
                name: "tbl_querymessages");

            migrationBuilder.DropTable(
                name: "tbl_review");

            migrationBuilder.DropTable(
                name: "tbl_settings");

            migrationBuilder.DropTable(
                name: "tbl_slider");

            migrationBuilder.DropTable(
                name: "tbl_user");
        }
    }
}
