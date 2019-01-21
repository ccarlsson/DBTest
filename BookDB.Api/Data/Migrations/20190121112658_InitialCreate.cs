using Microsoft.EntityFrameworkCore.Migrations;

namespace BookDB.Api.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "BookCopies",
                columns: table => new
                {
                    BookId = table.Column<string>(nullable: false),
                    CopyNumber = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCopies", x => new { x.BookId, x.CopyNumber });
                    table.ForeignKey(
                        name: "FK_BookCopies_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "ImageUrl", "Title" },
                values: new object[] { "9789140674029", "Magnus Lilja, Ulrik Nilsson", "https://s2.adlibris.com/images/1796891/programmering-1-c.jpg", "Programmering 1 C#" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "ImageUrl", "Title" },
                values: new object[] { "9789140677099", "Magnus Lilja, Ulrik Nilsson, Bo Silborn", "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg", "Programmering 1 C++" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "ImageUrl", "Title" },
                values: new object[] { "9789140677105", "Magnus Lilja, Ulrik Nilsson, Bo Silborn", "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg", "Programmering 1 Java" });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140674029", 1, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140674029", 2, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140674029", 3, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140674029", 4, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140674029", 5, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677099", 1, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677099", 2, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677099", 3, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677099", 4, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677099", 5, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677105", 1, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677105", 2, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677105", 3, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677105", 4, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "BookId", "CopyNumber", "Description" },
                values: new object[] { "9789140677105", 5, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCopies");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
