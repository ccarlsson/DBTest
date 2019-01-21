using Microsoft.EntityFrameworkCore.Migrations;

namespace BookDB.Api.Data.Migrations
{
    public partial class ChangeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9789140677105",
                column: "ImageUrl",
                value: "https://s1.adlibris.com/images/966044/programmering-1-java.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9789140677105",
                column: "ImageUrl",
                value: "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg");
        }
    }
}
