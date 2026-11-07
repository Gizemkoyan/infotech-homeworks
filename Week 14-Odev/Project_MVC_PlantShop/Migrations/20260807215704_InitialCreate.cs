using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_PlantShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plantCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    PlantCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_plants_plantCategories_PlantCategoryId",
                        column: x => x.PlantCategoryId,
                        principalTable: "plantCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "plantCategories",
                columns: new[] { "Id", "Description", "name" },
                values: new object[,]
                {
                    { 1, "Az Su İsteyen Dayanıklı Bitkiler", "Skulent" },
                    { 2, "Ev Ve Ofis Bitkileri", "İç Mekan" },
                    { 3, "Bahçe Ve Balkon Bitkileri", "Dış Mekan" },
                    { 4, "Saksılar,Tabaklar,Destek Çubukları", "Saksı & Aksesuar" },
                    { 5, "Ekime Hazır Tohum Ve Fideler", "Tohum & Fide" }
                });

            migrationBuilder.InsertData(
                table: "plants",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PlantCategoryId", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Bakımı Kolay Ve Dayanıklı Bir Skulent", "https://placehold.co/600x400/4CAF50/white?text=Aloe+Vera", "Aleo Vera", 1, 150.00m, 20 },
                    { 2, "Renkli yapraklarıyla dekoratif bir sukulent.", "https://placehold.co/600x400/66BB6A/white?text=Echeveria", "Echeveria", 1, 120.00m, 15 },
                    { 3, "Küçük alanlar için uygun dayanıklı bir sukulent.", "https://placehold.co/600x400/388E3C/white?text=Haworthia", "Haworthia", 1, 100.00m, 18 },
                    { 4, "Geniş yapraklı popüler bir iç mekân bitkisi.", "https://placehold.co/600x400/2E7D32/white?text=Monstera", "Monstera", 2, 450.00m, 10 },
                    { 5, "Ev ve ofis ortamlarına uygun dekoratif bitki.", "https://placehold.co/600x400/43A047/white?text=Baris+Cicegi", "Barış Çiçeği", 2, 300.00m, 12 },
                    { 6, "Parlak ve büyük yapraklı bir salon bitkisi.", "https://placehold.co/600x400/1B5E20/white?text=Kaucuk", "Kauçuk", 2, 400.00m, 8 },
                    { 7, "Hoş kokulu ve dış mekâna uygun bir bitki.", "https://placehold.co/600x400/7E57C2/white?text=Lavanta", "Lavanta", 3, 180.00m, 25 },
                    { 8, "Renkli çiçekleriyle bahçeler için ideal.", "https://placehold.co/600x400/5C6BC0/white?text=Ortanca", "Ortanca", 3, 250.00m, 14 },
                    { 9, "Bahçeler için klasik ve dekoratif çiçek.", "https://placehold.co/600x400/E53935/white?text=Gul", "Gül", 3, 200.00m, 30 },
                    { 10, "İç ve dış mekân kullanımına uygun seramik saksı.", "https://placehold.co/600x400/8D6E63/white?text=Seramik+Saksi", "Seramik Saksı", 4, 220.00m, 20 },
                    { 11, "Saksı altlarında su birikmesini kontrol eder.", "https://placehold.co/600x400/A1887F/white?text=Saksi+Tabagi", "Saksı Tabağı", 4, 50.00m, 40 },
                    { 12, "Uzun bitkilerin dik durmasına yardımcı olur.", "https://placehold.co/600x400/795548/white?text=Destek+Cubugu", "Destek Çubuğu", 4, 75.00m, 35 },
                    { 13, "Ev ve bahçe ekimine uygun domates tohumu.", "https://placehold.co/600x400/F44336/white?text=Domates+Tohumu", "Domates Tohumu", 5, 40.00m, 50 },
                    { 14, "Bahçe ve balkon yetiştiriciliğine uygun fide.", "https://placehold.co/600x400/689F38/white?text=Biber+Fidesi", "Biber Fidesi", 5, 35.00m, 45 },
                    { 15, "Saksıda yetiştirmeye uygun aromatik bitki tohumu.", "https://placehold.co/600x400/558B2F/white?text=Feslegen+Tohumu", "Fesleğen Tohumu", 5, 30.00m, 60 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_plants_PlantCategoryId",
                table: "plants",
                column: "PlantCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plants");

            migrationBuilder.DropTable(
                name: "plantCategories");
        }
    }
}
