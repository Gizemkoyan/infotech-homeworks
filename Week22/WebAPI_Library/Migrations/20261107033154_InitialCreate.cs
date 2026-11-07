using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    PageCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "Title" },
                values: new object[,]
                {
                    { 1, "Sabahattin Ali", 160, "Kürk Mantolu Madonna" },
                    { 2, "Oğuz Atay", 724, "Tutunamayanlar" },
                    { 3, "Yaşar Kemal", 436, "İnce Memed" },
                    { 4, "Ahmet Hamdi Tanpınar", 382, "Saatleri Ayarlama Enstitüsü" },
                    { 5, "George Orwell", 352, "1984" },
                    { 6, "Fyodor Dostoyevski", 687, "Suç ve Ceza" },
                    { 7, "Victor Hugo", 1724, "Sefiller" },
                    { 8, "Paulo Coelho", 184, "Simyacı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
