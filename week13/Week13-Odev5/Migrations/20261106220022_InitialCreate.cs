using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week13_Odev5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Specialization = table.Column<string>(type: "text", nullable: false),
                    ExperienceYears = table.Column<int>(type: "integer", nullable: false),
                    PhotoUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    Fee = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    TrainerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitnessClasses_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ExperienceYears", "FirstName", "LastName", "PhotoUrl", "Specialization" },
                values: new object[,]
                {
                    { 1, 8, "Ahmet", "Yılmaz", "/images/ahmet.jpg", "Fitness" },
                    { 2, 6, "Ayşe", "Demir", "/images/ayse.jpg", "Pilates" },
                    { 3, 5, "Mehmet", "Kaya", "/images/mehmet.jpg", "Yoga" },
                    { 4, 7, "Zeynep", "Çelik", "/images/zeynep.jpg", "Zumba" }
                });

            migrationBuilder.InsertData(
                table: "FitnessClasses",
                columns: new[] { "Id", "Capacity", "ClassName", "Description", "DurationMinutes", "Fee", "IsActive", "TrainerId" },
                values: new object[,]
                {
                    { 1, 15, "Fitness Başlangıç", "Yeni başlayanlar için temel fitness eğitimi", 60, 250.00m, true, 1 },
                    { 2, 12, "İleri Seviye Fitness", "Deneyimli katılımcılar için kuvvet antrenmanı", 75, 350.00m, true, 1 },
                    { 3, 15, "Fonksiyonel Antrenman", "Dayanıklılık ve koordinasyon çalışmaları", 50, 300.00m, true, 1 },
                    { 4, 12, "Mat Pilates", "Mat üzerinde temel pilates hareketleri", 50, 280.00m, true, 2 },
                    { 5, 8, "Reformer Pilates", "Reformer ekipmanlarıyla pilates eğitimi", 55, 450.00m, true, 2 },
                    { 6, 15, "Başlangıç Yoga", "Temel yoga duruşları ve nefes egzersizleri", 60, 250.00m, true, 3 },
                    { 7, 12, "Vinyasa Yoga", "Akıcı yoga hareketleri ve esneklik çalışmaları", 70, 320.00m, true, 3 },
                    { 8, 20, "Meditasyon ve Nefes", "Rahatlama ve nefes teknikleri", 45, 200.00m, false, 3 },
                    { 9, 20, "Zumba", "Dans ve kardiyo temelli grup egzersizi", 60, 270.00m, true, 4 },
                    { 10, 18, "Zumba Gold", "Düşük tempolu dans ve fitness egzersizleri", 45, 230.00m, true, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClasses_TrainerId",
                table: "FitnessClasses",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FitnessClasses");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
