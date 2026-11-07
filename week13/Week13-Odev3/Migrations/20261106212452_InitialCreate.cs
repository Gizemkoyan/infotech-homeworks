using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week13_Odev3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    IsVegetarian = table.Column<bool>(type: "boolean", nullable: false),
                    PreparationTimeMinutes = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    MenuCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuCategories_MenuCategoryId",
                        column: x => x.MenuCategoryId,
                        principalTable: "MenuCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "Günlük hazırlanan sıcak çorbalar", 1, "Çorbalar" },
                    { 2, "Et ve tavuk yemekleri", 2, "Ana Yemekler" },
                    { 3, "Taze ve sağlıklı salatalar", 3, "Salatalar" },
                    { 4, "Geleneksel ve sütlü tatlılar", 4, "Tatlılar" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsVegetarian", "MenuCategoryId", "Name", "PreparationTimeMinutes", "Price" },
                values: new object[,]
                {
                    { 1, "Geleneksel mercimek çorbası", "/images/mercimek.jpg", true, 1, "Mercimek Çorbası", 15, 90.00m },
                    { 2, "Baharatlı ezogelin çorbası", "/images/ezogelin.jpg", true, 1, "Ezogelin Çorbası", 20, 95.00m },
                    { 3, "Kaşarlı domates çorbası", "/images/domates.jpg", true, 1, "Domates Çorbası", 15, 85.00m },
                    { 4, "Pilav ve közlenmiş sebzelerle", "/images/kofte.jpg", false, 2, "Izgara Köfte", 30, 280.00m },
                    { 5, "Özel soslu ızgara tavuk", "/images/tavuk.jpg", false, 2, "Tavuk Şiş", 25, 240.00m },
                    { 6, "Sebzeli dana eti sote", "/images/etsote.jpg", false, 2, "Et Sote", 35, 350.00m },
                    { 7, "Domates, salatalık ve biber", "/images/coban.jpg", true, 3, "Çoban Salata", 10, 110.00m },
                    { 8, "Marul, kruton ve özel sos", "/images/sezar.jpg", true, 3, "Sezar Salata", 15, 160.00m },
                    { 9, "Beyaz peynirli Akdeniz yeşillikleri", "/images/akdeniz.jpg", true, 3, "Akdeniz Salata", 10, 140.00m },
                    { 10, "Fırında geleneksel sütlaç", "/images/sutlac.jpg", true, 4, "Sütlaç", 20, 120.00m },
                    { 11, "Karamelize sütlü tatlı", "/images/kazandibi.jpg", true, 4, "Kazandibi", 20, 130.00m },
                    { 12, "Antep fıstıklı baklava", "/images/baklava.jpg", true, 4, "Baklava", 10, 190.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuCategoryId",
                table: "MenuItems",
                column: "MenuCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuCategories");
        }
    }
}
