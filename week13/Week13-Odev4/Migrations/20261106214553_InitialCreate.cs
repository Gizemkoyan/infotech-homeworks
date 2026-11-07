using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week13_Odev4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Director = table.Column<string>(type: "text", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: false),
                    ImdbRating = table.Column<double>(type: "double precision", nullable: false),
                    PosterUrl = table.Column<string>(type: "text", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bilim ve teknoloji temalı filmler", "Bilim Kurgu" },
                    { 2, "Duygusal ve gerçekçi hikayeler", "Dram" },
                    { 3, "Macera ve heyecan dolu filmler", "Aksiyon" },
                    { 4, "Eğlenceli ve mizah içerikli filmler", "Komedi" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "DurationMinutes", "GenreId", "ImdbRating", "PosterUrl", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Christopher Nolan", 169, 1, 8.6999999999999993, "/images/interstellar.jpg", 2014, "Interstellar" },
                    { 2, "Christopher Nolan", 148, 1, 8.8000000000000007, "/images/inception.jpg", 2010, "Inception" },
                    { 3, "Lana Wachowski, Lilly Wachowski", 136, 1, 8.6999999999999993, "/images/matrix.jpg", 1999, "The Matrix" },
                    { 4, "Frank Darabont", 142, 2, 9.3000000000000007, "/images/shawshank.jpg", 1994, "The Shawshank Redemption" },
                    { 5, "Robert Zemeckis", 142, 2, 8.8000000000000007, "/images/forrestgump.jpg", 1994, "Forrest Gump" },
                    { 6, "Frank Darabont", 189, 2, 8.5999999999999996, "/images/greenmile.jpg", 1999, "The Green Mile" },
                    { 7, "Christopher Nolan", 152, 3, 9.0, "/images/darkknight.jpg", 2008, "The Dark Knight" },
                    { 8, "Chad Stahelski", 101, 3, 7.5, "/images/johnwick.jpg", 2014, "John Wick" },
                    { 9, "George Miller", 120, 3, 8.0999999999999996, "/images/madmax.jpg", 2015, "Mad Max: Fury Road" },
                    { 10, "Todd Phillips", 100, 4, 7.7000000000000002, "/images/hangover.jpg", 2009, "The Hangover" },
                    { 11, "Chris Columbus", 103, 4, 7.7000000000000002, "/images/homealone.jpg", 1990, "Home Alone" },
                    { 12, "Chuck Russell", 101, 4, 6.9000000000000004, "/images/mask.jpg", 1994, "The Mask" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
