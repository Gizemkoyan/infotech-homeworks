using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_BikeShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    FrameSize = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    BikeCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bikes_BikeCategories_BikeCategoryId",
                        column: x => x.BikeCategoryId,
                        principalTable: "BikeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BikeCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Günlük kullanım ve şehir içi ulaşım", "Şehir Bisikleti" },
                    { 2, "Arazi ve patika sürüşü", "Dağ Bisikleti" },
                    { 3, "Hız ve uzun mesafe", "Yol Bisikleti" },
                    { 4, "Çocuklar için güvenli modeller", "Çocuk Bisikleti" },
                    { 5, "Motor destekli bisikletler", "Elektrikli Bisiklet" }
                });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "BikeCategoryId", "Description", "FrameSize", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, "Günlük şehir içi ulaşım için konforlu bisiklet.", "M", "https://placehold.co/600x400/87CEEB/FFFFFF?text=Bianchi+Touring", "Bianchi Touring 28", 18500m, 8 },
                    { 2, 1, "Hafif ve dayanıklı şehir bisikleti.", "L", "https://placehold.co/600x400/4682B4/FFFFFF?text=Carraro+Sportive", "Carraro Sportive 225", 22000m, 5 },
                    { 3, 1, "Şehir içi ve hafif arazi kullanımına uygun.", "S", "https://placehold.co/600x400/20B2AA/FFFFFF?text=Kron+TX+150", "Kron TX 150", 14500m, 12 },
                    { 4, 2, "Zorlu araziler için dayanıklı dağ bisikleti.", "M", "https://placehold.co/600x400/228B22/FFFFFF?text=Scott+Aspect", "Scott Aspect 950", 42000m, 4 },
                    { 5, 2, "Patika sürüşleri için güçlü ve dengeli model.", "L", "https://placehold.co/600x400/006400/FFFFFF?text=Trek+Marlin", "Trek Marlin 6", 38500m, 6 },
                    { 6, 2, "Hafif alüminyum kadrolu dağ bisikleti.", "M", "https://placehold.co/600x400/556B2F/FFFFFF?text=Giant+Talon", "Giant Talon 3", 29500m, 0 },
                    { 7, 3, "Hızlı ve verimli yol sürüşleri için tasarlandı.", "M", "https://placehold.co/600x400/DC143C/FFFFFF?text=Specialized+Allez", "Specialized Allez", 65000m, 3 },
                    { 8, 3, "Hafif kadrolu performans yol bisikleti.", "L", "https://placehold.co/600x400/B22222/FFFFFF?text=Cannondale+CAAD", "Cannondale CAAD Optimo", 58000m, 2 },
                    { 9, 3, "Uzun mesafe sürüşlerinde konfor ve performans.", "XL", "https://placehold.co/600x400/8B0000/FFFFFF?text=Bianchi+Via+Nirone", "Bianchi Via Nirone 7", 72000m, 4 },
                    { 10, 4, "Çocuklar için güvenli ve dayanıklı bisiklet.", "S", "https://placehold.co/600x400/FF69B4/FFFFFF?text=Bisan+KDS", "Bisan KDS 2200", 8500m, 10 },
                    { 11, 4, "Renkli tasarımlı çocuk bisikleti.", "S", "https://placehold.co/600x400/FF1493/FFFFFF?text=Carraro+Moggy", "Carraro Moggy 20", 10500m, 7 },
                    { 12, 4, "Çocuklar için hafif ve kullanışlı model.", "S", "https://placehold.co/600x400/DA70D6/FFFFFF?text=Kron+XC+20", "Kron XC 20", 9200m, 0 },
                    { 13, 5, "Şehir içi ulaşım için motor destekli bisiklet.", "M", "https://placehold.co/600x400/4169E1/FFFFFF?text=RKS+RS3+Pro", "RKS RS3 Pro", 48500m, 5 },
                    { 14, 5, "Ekonomik ve pratik elektrikli bisiklet.", "L", "https://placehold.co/600x400/000080/FFFFFF?text=Volta+VB7", "Volta VB7", 32000m, 9 },
                    { 15, 5, "Katlanabilir ve taşınabilir elektrikli bisiklet.", "M", "https://placehold.co/600x400/483D8B/FFFFFF?text=Carraro+E+Flex", "Carraro E-Flex", 56000m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeCategoryId",
                table: "Bikes",
                column: "BikeCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "BikeCategories");
        }
    }
}
