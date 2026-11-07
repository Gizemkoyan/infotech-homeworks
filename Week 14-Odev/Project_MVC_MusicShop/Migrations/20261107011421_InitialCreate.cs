using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstrumentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    InstrumentCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instruments_InstrumentCategories_InstrumentCategoryId",
                        column: x => x.InstrumentCategoryId,
                        principalTable: "InstrumentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InstrumentCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Klasik, akustik ve elektro gitarlar", "Gitar" },
                    { 2, "Piyano, synthesizer ve midi klavyeler", "Piyano & Klavye" },
                    { 3, "Davul setleri ve perküsyon aletleri", "Davul & Perküsyon" },
                    { 4, "Keman, viyola, çello", "Yaylı Çalgılar" },
                    { 5, "Flüt, saksofon, trompet", "Üflemeli Çalgılar" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "Brand", "Description", "ImageUrl", "InstrumentCategoryId", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Fender", "Elektro gitar, akçaağaç sap ve üç single-coil manyetik", "https://placehold.co/600x400/2563eb/ffffff?text=Player+Stratocaster", 1, "Player Stratocaster", 35000m, 8 },
                    { 2, "Yamaha", "Yeni başlayanlar için akustik gitar", "https://placehold.co/600x400/16a34a/ffffff?text=Yamaha+F310", 1, "F310", 7500m, 12 },
                    { 3, "Yamaha", "Klasik gitar, naylon teller ve doğal ahşap gövde", "https://placehold.co/600x400/d97706/ffffff?text=Yamaha+C40", 1, "C40", 6500m, 4 },
                    { 4, "Roland", "88 tuşlu dijital piyano", "https://placehold.co/600x400/7c3aed/ffffff?text=Roland+FP30X", 2, "FP-30X", 42000m, 6 },
                    { 5, "Yamaha", "Taşınabilir dijital klavye", "https://placehold.co/600x400/0891b2/ffffff?text=Yamaha+PSR", 2, "PSR-E373", 14500m, 9 },
                    { 6, "Yamaha", "88 tuşlu, ağırlıklı tuş mekanizmalı dijital piyano", "https://placehold.co/600x400/475569/ffffff?text=Yamaha+P45", 2, "P-45", 28500m, 5 },
                    { 7, "Roland", "Kompakt elektronik davul seti", "https://placehold.co/600x400/dc2626/ffffff?text=Roland+TD07", 3, "TD-07DMK", 52000m, 3 },
                    { 8, "Yamaha", "Profesyonel akustik davul seti", "https://placehold.co/600x400/ea580c/ffffff?text=Stage+Custom", 3, "Stage Custom Birch", 68000m, 2 },
                    { 9, "Meinl", "Başlangıç seviyesi zil seti", "https://placehold.co/600x400/ca8a04/ffffff?text=Meinl+HCS", 3, "HCS Cymbal Set", 12500m, 10 },
                    { 10, "Yamaha", "Öğrenciler için tasarlanmış akustik keman", "https://placehold.co/600x400/9333ea/ffffff?text=Yamaha+V5", 4, "V5 SC", 18500m, 7 },
                    { 11, "Stentor", "Öğrenciler için başlangıç seviyesi viyola", "https://placehold.co/600x400/8b5cf6/ffffff?text=Stentor+Viola", 4, "Student II Viola", 22000m, 4 },
                    { 12, "Yamaha", "El yapımı akustik çello", "https://placehold.co/600x400/6d28d9/ffffff?text=Yamaha+Cello", 4, "VC5S Cello", 58000m, 2 },
                    { 13, "Yamaha", "Gümüş kaplama öğrenci flütü", "https://placehold.co/600x400/0284c7/ffffff?text=Yamaha+Flute", 5, "YFL-222", 32000m, 6 },
                    { 14, "Jean Paul", "Başlangıç ve orta seviye alto saksofon", "https://placehold.co/600x400/0d9488/ffffff?text=Alto+Saxophone", 5, "AS-400", 45000m, 3 },
                    { 15, "Jupiter", "Öğrenciler için Si bemol trompet", "https://placehold.co/600x400/059669/ffffff?text=Jupiter+Trumpet", 5, "TR-330", 19500m, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_InstrumentCategoryId",
                table: "Instruments",
                column: "InstrumentCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "InstrumentCategories");
        }
    }
}
