
using Microsoft.EntityFrameworkCore;
using Project_MVC_BikeShop.Models;

namespace Project_MVC_BikeShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<BikeCategory> BikeCategories { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PedalaBin.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BikeCategory>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Bike>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Bike>()
                .Property(b => b.FrameSize)
                .IsRequired();

            modelBuilder.Entity<Bike>()
                .Property(b => b.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Bike>()
                .HasOne(b => b.BikeCategory)
                .WithMany(c => c.Bikes)
                .HasForeignKey(b => b.BikeCategoryId);
            
            
            modelBuilder.Entity<BikeCategory>().HasData(
                new BikeCategory
                {
                    Id = 1,
                    Name = "Şehir Bisikleti",
                    Description = "Günlük kullanım ve şehir içi ulaşım"
                },
                new BikeCategory
                {
                    Id = 2,
                    Name = "Dağ Bisikleti",
                    Description = "Arazi ve patika sürüşü"
                },
                new BikeCategory
                {
                    Id = 3,
                    Name = "Yol Bisikleti",
                    Description = "Hız ve uzun mesafe"
                },
                new BikeCategory
                {
                    Id = 4,
                    Name = "Çocuk Bisikleti",
                    Description = "Çocuklar için güvenli modeller"
                },
                new BikeCategory
                {
                    Id = 5,
                    Name = "Elektrikli Bisiklet",
                    Description = "Motor destekli bisikletler"
                }
            );
            
            modelBuilder.Entity<Bike>().HasData(
                // Şehir Bisikletleri
                new Bike
                {
                    Id = 1,
                    Name = "Bianchi Touring 28",
                    Description = "Günlük şehir içi ulaşım için konforlu bisiklet.",
                    Price = 18500,
                    StockQuantity = 8,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/87CEEB/FFFFFF?text=Bianchi+Touring",
                    BikeCategoryId = 1
                },
                new Bike
                {
                    Id = 2,
                    Name = "Carraro Sportive 225",
                    Description = "Hafif ve dayanıklı şehir bisikleti.",
                    Price = 22000,
                    StockQuantity = 5,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/4682B4/FFFFFF?text=Carraro+Sportive",
                    BikeCategoryId = 1
                },
                new Bike
                {
                    Id = 3,
                    Name = "Kron TX 150",
                    Description = "Şehir içi ve hafif arazi kullanımına uygun.",
                    Price = 14500,
                    StockQuantity = 12,
                    FrameSize = "S",
                    ImageUrl = "https://placehold.co/600x400/20B2AA/FFFFFF?text=Kron+TX+150",
                    BikeCategoryId = 1
                },

                // Dağ Bisikletleri
                new Bike
                {
                    Id = 4,
                    Name = "Scott Aspect 950",
                    Description = "Zorlu araziler için dayanıklı dağ bisikleti.",
                    Price = 42000,
                    StockQuantity = 4,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/228B22/FFFFFF?text=Scott+Aspect",
                    BikeCategoryId = 2
                },
                new Bike
                {
                    Id = 5,
                    Name = "Trek Marlin 6",
                    Description = "Patika sürüşleri için güçlü ve dengeli model.",
                    Price = 38500,
                    StockQuantity = 6,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/006400/FFFFFF?text=Trek+Marlin",
                    BikeCategoryId = 2
                },
                new Bike
                {
                    Id = 6,
                    Name = "Giant Talon 3",
                    Description = "Hafif alüminyum kadrolu dağ bisikleti.",
                    Price = 29500,
                    StockQuantity = 0,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/556B2F/FFFFFF?text=Giant+Talon",
                    BikeCategoryId = 2
                },

                // Yol Bisikletleri
                new Bike
                {
                    Id = 7,
                    Name = "Specialized Allez",
                    Description = "Hızlı ve verimli yol sürüşleri için tasarlandı.",
                    Price = 65000,
                    StockQuantity = 3,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/DC143C/FFFFFF?text=Specialized+Allez",
                    BikeCategoryId = 3
                },
                new Bike
                {
                    Id = 8,
                    Name = "Cannondale CAAD Optimo",
                    Description = "Hafif kadrolu performans yol bisikleti.",
                    Price = 58000,
                    StockQuantity = 2,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/B22222/FFFFFF?text=Cannondale+CAAD",
                    BikeCategoryId = 3
                },
                new Bike
                {
                    Id = 9,
                    Name = "Bianchi Via Nirone 7",
                    Description = "Uzun mesafe sürüşlerinde konfor ve performans.",
                    Price = 72000,
                    StockQuantity = 4,
                    FrameSize = "XL",
                    ImageUrl = "https://placehold.co/600x400/8B0000/FFFFFF?text=Bianchi+Via+Nirone",
                    BikeCategoryId = 3
                },

                // Çocuk Bisikletleri
                new Bike
                {
                    Id = 10,
                    Name = "Bisan KDS 2200",
                    Description = "Çocuklar için güvenli ve dayanıklı bisiklet.",
                    Price = 8500,
                    StockQuantity = 10,
                    FrameSize = "S",
                    ImageUrl = "https://placehold.co/600x400/FF69B4/FFFFFF?text=Bisan+KDS",
                    BikeCategoryId = 4
                },
                new Bike
                {
                    Id = 11,
                    Name = "Carraro Moggy 20",
                    Description = "Renkli tasarımlı çocuk bisikleti.",
                    Price = 10500,
                    StockQuantity = 7,
                    FrameSize = "S",
                    ImageUrl = "https://placehold.co/600x400/FF1493/FFFFFF?text=Carraro+Moggy",
                    BikeCategoryId = 4
                },
                new Bike
                {
                    Id = 12,
                    Name = "Kron XC 20",
                    Description = "Çocuklar için hafif ve kullanışlı model.",
                    Price = 9200,
                    StockQuantity = 0,
                    FrameSize = "S",
                    ImageUrl = "https://placehold.co/600x400/DA70D6/FFFFFF?text=Kron+XC+20",
                    BikeCategoryId = 4
                },

                // Elektrikli Bisikletler
                new Bike
                {
                    Id = 13,
                    Name = "RKS RS3 Pro",
                    Description = "Şehir içi ulaşım için motor destekli bisiklet.",
                    Price = 48500,
                    StockQuantity = 5,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/4169E1/FFFFFF?text=RKS+RS3+Pro",
                    BikeCategoryId = 5
                },
                new Bike
                {
                    Id = 14,
                    Name = "Volta VB7",
                    Description = "Ekonomik ve pratik elektrikli bisiklet.",
                    Price = 32000,
                    StockQuantity = 9,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/000080/FFFFFF?text=Volta+VB7",
                    BikeCategoryId = 5
                },
                new Bike
                {
                    Id = 15,
                    Name = "Carraro E-Flex",
                    Description = "Katlanabilir ve taşınabilir elektrikli bisiklet.",
                    Price = 56000,
                    StockQuantity = 3,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/483D8B/FFFFFF?text=Carraro+E+Flex",
                    BikeCategoryId = 5
                },
                
                new Bike
                {
                    Id = 16,
                    Name = "Bianchi Spillo",
                    Description = "Konforlu şehir içi sürüşler için ideal bisiklet.",
                    Price = 24500,
                    StockQuantity = 6,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/5F9EA0/FFFFFF?text=Bianchi+Spillo",
                    BikeCategoryId = 1
                },
                new Bike
                {
                    Id = 17,
                    Name = "Carraro Big 929",
                    Description = "Dağ yolları ve zorlu parkurlar için güçlü model.",
                    Price = 34500,
                    StockQuantity = 4,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/2E8B57/FFFFFF?text=Carraro+Big+929",
                    BikeCategoryId = 2
                },
                new Bike
                {
                    Id = 18,
                    Name = "Giant Contend 3",
                    Description = "Uzun mesafelerde hızlı ve dengeli yol bisikleti.",
                    Price = 46500,
                    StockQuantity = 5,
                    FrameSize = "M",
                    ImageUrl = "https://placehold.co/600x400/CD5C5C/FFFFFF?text=Giant+Contend",
                    BikeCategoryId = 3
                },
                new Bike
                {
                    Id = 19,
                    Name = "Bisan Happy 20",
                    Description = "Çocuklar için eğlenceli ve güvenli bisiklet.",
                    Price = 7800,
                    StockQuantity = 11,
                    FrameSize = "S",
                    ImageUrl = "https://placehold.co/600x400/FFB6C1/FFFFFF?text=Bisan+Happy",
                    BikeCategoryId = 4
                },
                new Bike
                {
                    Id = 20,
                    Name = "RKS MX25",
                    Description = "Güçlü motor desteğine sahip elektrikli bisiklet.",
                    Price = 59500,
                    StockQuantity = 3,
                    FrameSize = "L",
                    ImageUrl = "https://placehold.co/600x400/6495ED/FFFFFF?text=RKS+MX25",
                    BikeCategoryId = 5
                }
            );

        }
    }
}
