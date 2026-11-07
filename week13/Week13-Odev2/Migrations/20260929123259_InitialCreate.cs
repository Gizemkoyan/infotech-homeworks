using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week13_Odev2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    BirthYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    PageCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedYear = table.Column<int>(type: "integer", nullable: false),
                    StockCount = table.Column<int>(type: "integer", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthYear", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { 1, 1907, "Sabahattin", "Ali", "Türk" },
                    { 2, 1903, "George", "Orwell", "İngiliz" },
                    { 3, 1821, "Fyodor", "Dostoyevski", "Rus" },
                    { 4, 1881, "Stefan", "Zweig", "Avusturyalı" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CoverImageUrl", "ISBN", "PageCount", "PublishedYear", "StockCount", "Title" },
                values: new object[,]
                {
                    { 1, 1, "/images/book1.jpg", "9789753638029", 160, 1943, 12, "Kürk Mantolu Madonna" },
                    { 2, 1, "/images/book2.jpg", "9789750800016", 220, 1937, 8, "Kuyucaklı Yusuf" },
                    { 3, 1, "/images/book3.jpg", "9789753638036", 256, 1940, 10, "İçimizdeki Şeytan" },
                    { 4, 2, "/images/book4.jpg", "9780451524935", 328, 1949, 15, "1984" },
                    { 5, 2, "/images/book5.jpg", "9780451526342", 112, 1945, 20, "Hayvan Çiftliği" },
                    { 6, 3, "/images/book6.jpg", "9780140449136", 671, 1866, 7, "Suç ve Ceza" },
                    { 7, 3, "/images/book7.jpg", "9780374528379", 824, 1880, 5, "Karamazov Kardeşler" },
                    { 8, 3, "/images/book8.jpg", "9780486469736", 128, 1848, 11, "Beyaz Geceler" },
                    { 9, 4, "/images/book9.jpg", "9789750738609", 80, 1942, 18, "Satranç" },
                    { 10, 4, "/images/book10.jpg", "9786053320487", 72, 1922, 9, "Bilinmeyen Bir Kadının Mektubu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
