using Microsoft.EntityFrameworkCore;
using Project_MVC_PlantShop.Models;

namespace Project_MVC_PlantShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PlantCategory> PlantCategories { get; set; }
        public DbSet<Plant> Plants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=YesilDunya.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>().Property(p => p.Price).HasPrecision(10,2);
            modelBuilder.Entity<PlantCategory>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Plant>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<PlantCategory>().HasData(
                new PlantCategory
                {
                    Id=1,
                    Name="Skulent",
                    Description="Az Su İsteyen Dayanıklı Bitkiler"
                },
                new PlantCategory
                {
                    Id=2,
                    Name="İç Mekan",
                    Description="Ev Ve Ofis Bitkileri"
                },
                new PlantCategory
                {
                    Id=3,
                    Name="Dış Mekan",
                    Description="Bahçe Ve Balkon Bitkileri"
                },
                new PlantCategory
                {
                    Id=4,
                    Name="Saksı & Aksesuar",
                    Description="Saksılar,Tabaklar,Destek Çubukları"
                },
                new PlantCategory
                {
                    Id=5,
                    Name="Tohum & Fide",
                    Description="Ekime Hazır Tohum Ve Fideler"
                }
            );

            modelBuilder.Entity<Plant>().HasData(
                new Plant
                {
                    Id=1,
                    Name="Aleo Vera",
                    Description="Bakımı Kolay Ve Dayanıklı Bir Skulent",
                    Price=150.00m,
                    StockQuantity=20,
                    ImageUrl="https://placehold.co/600x400/4CAF50/white?text=Aloe+Vera",
                    PlantCategoryId=1
                },
                new Plant
                {
                    Id = 2,
                    Name = "Echeveria",
                    Description = "Renkli yapraklarıyla dekoratif bir sukulent.",
                    Price = 120.00m,
                    StockQuantity = 15,
                    ImageUrl = "https://placehold.co/600x400/66BB6A/white?text=Echeveria",
                    PlantCategoryId = 1
                },
                new Plant
                {
                    Id = 3,
                    Name = "Haworthia",
                    Description = "Küçük alanlar için uygun dayanıklı bir sukulent.",
                    Price = 100.00m,
                    StockQuantity = 18,
                    ImageUrl = "https://placehold.co/600x400/388E3C/white?text=Haworthia",
                    PlantCategoryId = 1
                },
                new Plant
                {
                    Id = 4,
                    Name = "Monstera",
                    Description = "Geniş yapraklı popüler bir iç mekân bitkisi.",
                    Price = 450.00m,
                    StockQuantity = 10,
                    ImageUrl = "https://placehold.co/600x400/2E7D32/white?text=Monstera",
                    PlantCategoryId = 2
                },
                new Plant
                {
                    Id = 5,
                    Name = "Barış Çiçeği",
                    Description = "Ev ve ofis ortamlarına uygun dekoratif bitki.",
                    Price = 300.00m,
                    StockQuantity = 12,
                    ImageUrl = "https://placehold.co/600x400/43A047/white?text=Baris+Cicegi",
                    PlantCategoryId = 2
                },
                new Plant
                {
                     Id = 6,
                    Name = "Kauçuk",
                    Description = "Parlak ve büyük yapraklı bir salon bitkisi.",
                    Price = 400.00m,
                    StockQuantity = 8,
                    ImageUrl = "https://placehold.co/600x400/1B5E20/white?text=Kaucuk",
                    PlantCategoryId = 2
                },
                new Plant
                {
                    Id = 7,
                    Name = "Lavanta",
                    Description = "Hoş kokulu ve dış mekâna uygun bir bitki.",
                    Price = 180.00m,
                    StockQuantity = 25,
                    ImageUrl = "https://placehold.co/600x400/7E57C2/white?text=Lavanta",
                    PlantCategoryId = 3
                },
                new Plant
                {
                    Id = 8,
                    Name = "Ortanca",
                    Description = "Renkli çiçekleriyle bahçeler için ideal.",
                    Price = 250.00m,
                    StockQuantity = 14,
                    ImageUrl = "https://placehold.co/600x400/5C6BC0/white?text=Ortanca",
                    PlantCategoryId = 3
                },
                new Plant
                {
                    Id = 9,
                    Name = "Gül",
                    Description = "Bahçeler için klasik ve dekoratif çiçek.",
                    Price = 200.00m,
                    StockQuantity = 30,
                    ImageUrl = "https://placehold.co/600x400/E53935/white?text=Gul",
                    PlantCategoryId = 3
                },
                new Plant
                {
                    Id = 10,
                    Name = "Seramik Saksı",
                    Description = "İç ve dış mekân kullanımına uygun seramik saksı.",
                    Price = 220.00m,
                    StockQuantity = 20,
                    ImageUrl = "https://placehold.co/600x400/8D6E63/white?text=Seramik+Saksi",
                    PlantCategoryId = 4
                },
                new Plant
                {
                    Id = 11,
                    Name = "Saksı Tabağı",
                    Description = "Saksı altlarında su birikmesini kontrol eder.",
                    Price = 50.00m,
                    StockQuantity = 40,
                    ImageUrl = "https://placehold.co/600x400/A1887F/white?text=Saksi+Tabagi",
                    PlantCategoryId = 4
                },
                new Plant
                {
                     Id = 12,
                    Name = "Destek Çubuğu",
                    Description = "Uzun bitkilerin dik durmasına yardımcı olur.",
                    Price = 75.00m,
                    StockQuantity = 35,
                    ImageUrl = "https://placehold.co/600x400/795548/white?text=Destek+Cubugu",
                    PlantCategoryId = 4
                },
                new Plant
                {
                    Id = 13,
                    Name = "Domates Tohumu",
                    Description = "Ev ve bahçe ekimine uygun domates tohumu.",
                    Price = 40.00m,
                    StockQuantity = 50,
                    ImageUrl = "https://placehold.co/600x400/F44336/white?text=Domates+Tohumu",
                    PlantCategoryId = 5
                },
                new Plant
                {
                    Id = 14,
                    Name = "Biber Fidesi",
                    Description = "Bahçe ve balkon yetiştiriciliğine uygun fide.",
                    Price = 35.00m,
                    StockQuantity = 45,
                    ImageUrl = "https://placehold.co/600x400/689F38/white?text=Biber+Fidesi",
                    PlantCategoryId = 5
                },
                new Plant
                {
                    Id = 15,
                    Name = "Fesleğen Tohumu",
                    Description = "Saksıda yetiştirmeye uygun aromatik bitki tohumu.",
                    Price = 30.00m,
                    StockQuantity = 60,
                    ImageUrl = "https://placehold.co/600x400/558B2F/white?text=Feslegen+Tohumu",
                    PlantCategoryId = 5
                },
                new Plant
                {
                    Id = 16,
                    Name = "Crassula Ovata",
                    Description = "Etli yapraklı, bakımı kolay bir sukulent.",
                    Price = 140.00m,
                    StockQuantity = 22,
                    ImageUrl = "https://placehold.co/600x400/4CAF50/white?text=Crassula+Ovata",
                    PlantCategoryId = 1
                },
                new Plant
                {
                    Id = 17,
                    Name = "Paşa Kılıcı",
                    Description = "Az bakım isteyen dayanıklı bir iç mekân bitkisi.",
                    Price = 275.00m,
                    StockQuantity = 16,
                    ImageUrl = "https://placehold.co/600x400/2E7D32/white?text=Pasa+Kilici",
                    PlantCategoryId = 2
                },
                new Plant
                {
                    Id = 18,
                    Name = "Begonya",
                    Description = "Renkli çiçekleriyle balkon ve bahçeler için uygundur.",
                    Price = 160.00m,
                    StockQuantity = 19,
                    ImageUrl = "https://placehold.co/600x400/E57373/white?text=Begonya",
                    PlantCategoryId = 3
                },
                new Plant
                {
                    Id = 19,
                    Name = "Hasır Saksı",
                    Description = "Dekoratif görünüm sağlayan hafif saksı.",
                    Price = 190.00m,
                    StockQuantity = 25,
                    ImageUrl = "https://placehold.co/600x400/A1887F/white?text=Hasir+Saksi",
                    PlantCategoryId = 4
                },
                new Plant
                {
                    Id = 20,
                    Name = "Maydanoz Tohumu",
                    Description = "Saksı ve bahçe ekimine uygun tohum.",
                    Price = 25.00m,
                    StockQuantity = 70,
                    ImageUrl = "https://placehold.co/600x400/558B2F/white?text=Maydanoz+Tohumu",
                    PlantCategoryId = 5
                }
            );
        }
    }
}