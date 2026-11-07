using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_MovieArchive.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Director = table.Column<string>(type: "text", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Frank Darabont", 1994, "The Shawshank Redemption" },
                    { 2, "Francis Ford Coppola", 1972, "The Godfather" },
                    { 3, "Christopher Nolan", 2008, "The Dark Knight" },
                    { 4, "Quentin Tarantino", 1994, "Pulp Fiction" },
                    { 5, "Robert Zemeckis", 1994, "Forrest Gump" },
                    { 6, "Christopher Nolan", 2010, "Inception" },
                    { 7, "Christopher Nolan", 2014, "Interstellar" },
                    { 8, "Bong Joon-ho", 2019, "Parasite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
