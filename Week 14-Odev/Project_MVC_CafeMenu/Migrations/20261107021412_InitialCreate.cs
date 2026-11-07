using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_CafeMenu.Migrations
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    PreparationTimeMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    MenuCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
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
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Güne başlangıç lezzetleri", "Kahvaltı" },
                    { 2, "Doyurucu ana yemekler", "Ana Yemek" },
                    { 3, "Ev yapımı tatlılar", "Tatlı" },
                    { 4, "Sıcak ve soğuk içecekler", "İçecek" },
                    { 5, "Hafif atıştırmalıklar", "Atıştırmalık" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsAvailable", "MenuCategoryId", "Name", "PreparationTimeMinutes", "Price" },
                values: new object[,]
                {
                    { 1, "Peynir, zeytin, reçel, yumurta ve sıcak ekmek.", "https://placehold.co/600x400/FFE4B5/000000?text=Serpme+Kahvalti", true, 1, "Serpme Kahvaltı", 25, 450m },
                    { 2, "Domates, biber ve yumurta ile hazırlanır.", "https://placehold.co/600x400/FFDAB9/000000?text=Menemen", true, 1, "Menemen", 15, 180m },
                    { 3, "Bol kaşarlı, çıtır ekmekli tost.", "https://placehold.co/600x400/F5DEB3/000000?text=Kasarli+Tost", true, 1, "Kaşarlı Tost", 10, 140m },
                    { 4, "Patates kızartması ve salata ile servis edilir.", "https://placehold.co/600x400/D2B48C/000000?text=Izgara+Kofte", true, 2, "Izgara Köfte", 30, 390m },
                    { 5, "Kremalı sos ve tavuk parçalarıyla hazırlanır.", "https://placehold.co/600x400/FAEBD7/000000?text=Tavuklu+Makarna", true, 2, "Tavuklu Makarna", 20, 320m },
                    { 6, "Dana köfte, cheddar peyniri ve özel sos.", "https://placehold.co/600x400/DEB887/000000?text=Cheeseburger", false, 2, "Cheeseburger", 25, 350m },
                    { 7, "Kremamsı dokulu, hafif yanık cheesecake.", "https://placehold.co/600x400/FFF8DC/000000?text=Cheesecake", true, 3, "San Sebastian Cheesecake", 5, 240m },
                    { 8, "İçi akışkan çikolatalı sıcak tatlı.", "https://placehold.co/600x400/8B4513/FFFFFF?text=Sufle", true, 3, "Sufle", 15, 210m },
                    { 9, "Geleneksel fırın sütlaç.", "https://placehold.co/600x400/FFFACD/000000?text=Sutlac", true, 3, "Sütlaç", 5, 160m },
                    { 10, "Geleneksel yöntemle hazırlanan Türk kahvesi.", "https://placehold.co/600x400/6F4E37/FFFFFF?text=Turk+Kahvesi", true, 4, "Türk Kahvesi", 7, 110m },
                    { 11, "Espresso ve süt köpüğüyle hazırlanan kahve.", "https://placehold.co/600x400/C4A484/000000?text=Latte", true, 4, "Latte", 5, 150m },
                    { 12, "Taze limonlarla hazırlanan ev yapımı limonata.", "https://placehold.co/600x400/FFF44F/000000?text=Limonata", false, 4, "Limonata", 5, 130m },
                    { 13, "Çıtır patates kızartması ve özel sos.", "https://placehold.co/600x400/FFD700/000000?text=Patates", true, 5, "Patates Kızartması", 12, 160m },
                    { 14, "Çıtır kaplamalı soğan halkaları.", "https://placehold.co/600x400/F4A460/000000?text=Sogan+Halkasi", true, 5, "Soğan Halkası", 10, 170m },
                    { 15, "Mısır cipsi, cheddar sos ve jalapeno.", "https://placehold.co/600x400/FFA500/000000?text=Nachos", true, 5, "Nachos", 10, 220m }
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
