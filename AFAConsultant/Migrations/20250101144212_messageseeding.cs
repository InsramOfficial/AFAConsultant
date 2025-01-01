using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFAConsultant.Migrations
{
    public partial class messageseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_querymessages",
                columns: new[] { "Id", "Email", "Message", "Name", "PhoneNumber", "Subject" },
                values: new object[] { 2, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" });

            migrationBuilder.InsertData(
                table: "tbl_querymessages",
                columns: new[] { "Id", "Email", "Message", "Name", "PhoneNumber", "Subject" },
                values: new object[] { 3, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" });

            migrationBuilder.InsertData(
                table: "tbl_querymessages",
                columns: new[] { "Id", "Email", "Message", "Name", "PhoneNumber", "Subject" },
                values: new object[] { 4, "naseershabbir@gmail.com", "This is my Message", "Naseer", "12345", "Problem" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_querymessages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_querymessages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_querymessages",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
