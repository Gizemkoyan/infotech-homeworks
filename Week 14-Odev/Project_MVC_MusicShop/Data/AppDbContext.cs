using Microsoft.EntityFrameworkCore;
using Project_MVC_MusicShop.Models;

namespace Project_MVC_MusicShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<InstrumentCategory> InstrumentCategories { get; set; }

        public DbSet<Instrument> Instruments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MuzikDuragi.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<InstrumentCategory>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Instrument>()
                .Property(i => i.Name)
                .IsRequired();

            modelBuilder.Entity<Instrument>()
                .Property(i => i.Brand)
                .IsRequired();

            modelBuilder.Entity<Instrument>()
                .Property(i => i.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Instrument>()
                .HasOne(i => i.InstrumentCategory)
                .WithMany(c => c.Instruments)
                .HasForeignKey(i => i.InstrumentCategoryId);
            
            modelBuilder.Entity<InstrumentCategory>().HasData(
            new InstrumentCategory
            {
                Id = 1,
                Name = "Gitar",
                Description = "Klasik, akustik ve elektro gitarlar"
            },
            new InstrumentCategory
            {
                Id = 2,
                Name = "Piyano & Klavye",
                Description = "Piyano, synthesizer ve midi klavyeler"
            },
            new InstrumentCategory
            {
                Id = 3,
                Name = "Davul & Perküsyon",
                Description = "Davul setleri ve perküsyon aletleri"
            },
            new InstrumentCategory
            {
                Id = 4,
                Name = "Yaylı Çalgılar",
                Description = "Keman, viyola, çello"
            },
            new InstrumentCategory
            {
                Id = 5,
                Name = "Üflemeli Çalgılar",
                Description = "Flüt, saksofon, trompet"
            }
        );

        modelBuilder.Entity<Instrument>().HasData(
        new Instrument
        {
            Id = 1,
            Name = "Player Stratocaster",
            Description = "Elektro gitar, akçaağaç sap ve üç single-coil manyetik",
            Price = 35000m,
            StockQuantity = 8,
            Brand = "Fender",
            ImageUrl = "https://placehold.co/600x400/2563eb/ffffff?text=Player+Stratocaster",
            InstrumentCategoryId = 1
        },
        new Instrument
        {
            Id = 2,
            Name = "F310",
            Description = "Yeni başlayanlar için akustik gitar",
            Price = 7500m,
            StockQuantity = 12,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/16a34a/ffffff?text=Yamaha+F310",
            InstrumentCategoryId = 1
        },
        new Instrument
        {
            Id = 3,
            Name = "C40",
            Description = "Klasik gitar, naylon teller ve doğal ahşap gövde",
            Price = 6500m,
            StockQuantity = 4,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/d97706/ffffff?text=Yamaha+C40",
            InstrumentCategoryId = 1
        },
        new Instrument
        {
            Id = 4,
            Name = "FP-30X",
            Description = "88 tuşlu dijital piyano",
            Price = 42000m,
            StockQuantity = 6,
            Brand = "Roland",
            ImageUrl = "https://placehold.co/600x400/7c3aed/ffffff?text=Roland+FP30X",
            InstrumentCategoryId = 2
        },
        new Instrument
        {
            Id = 5,
            Name = "PSR-E373",
            Description = "Taşınabilir dijital klavye",
            Price = 14500m,
            StockQuantity = 9,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/0891b2/ffffff?text=Yamaha+PSR",
            InstrumentCategoryId = 2
        },
        new Instrument
        {
            Id = 6,
            Name = "P-45",
            Description = "88 tuşlu, ağırlıklı tuş mekanizmalı dijital piyano",
            Price = 28500m,
            StockQuantity = 5,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/475569/ffffff?text=Yamaha+P45",
            InstrumentCategoryId = 2
        },
        new Instrument
        {
            Id = 7,
            Name = "TD-07DMK",
            Description = "Kompakt elektronik davul seti",
            Price = 52000m,
            StockQuantity = 3,
            Brand = "Roland",
            ImageUrl = "https://placehold.co/600x400/dc2626/ffffff?text=Roland+TD07",
            InstrumentCategoryId = 3
        },
        new Instrument
        {
            Id = 8,
            Name = "Stage Custom Birch",
            Description = "Profesyonel akustik davul seti",
            Price = 68000m,
            StockQuantity = 2,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/ea580c/ffffff?text=Stage+Custom",
            InstrumentCategoryId = 3
        },
        new Instrument
        {
            Id = 9,
            Name = "HCS Cymbal Set",
            Description = "Başlangıç seviyesi zil seti",
            Price = 12500m,
            StockQuantity = 10,
            Brand = "Meinl",
            ImageUrl = "https://placehold.co/600x400/ca8a04/ffffff?text=Meinl+HCS",
            InstrumentCategoryId = 3
        },
        new Instrument
        {
            Id = 10,
            Name = "V5 SC",
            Description = "Öğrenciler için tasarlanmış akustik keman",
            Price = 18500m,
            StockQuantity = 7,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/9333ea/ffffff?text=Yamaha+V5",
            InstrumentCategoryId = 4
        },
        new Instrument
        {
            Id = 11,
            Name = "Student II Viola",
            Description = "Öğrenciler için başlangıç seviyesi viyola",
            Price = 22000m,
            StockQuantity = 4,
            Brand = "Stentor",
            ImageUrl = "https://placehold.co/600x400/8b5cf6/ffffff?text=Stentor+Viola",
            InstrumentCategoryId = 4
        },
        new Instrument
        {
            Id = 12,
            Name = "VC5S Cello",
            Description = "El yapımı akustik çello",
            Price = 58000m,
            StockQuantity = 2,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/6d28d9/ffffff?text=Yamaha+Cello",
            InstrumentCategoryId = 4
        },
        new Instrument
        {
            Id = 13,
            Name = "YFL-222",
            Description = "Gümüş kaplama öğrenci flütü",
            Price = 32000m,
            StockQuantity = 6,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/0284c7/ffffff?text=Yamaha+Flute",
            InstrumentCategoryId = 5
        },
        new Instrument
        {
            Id = 14,
            Name = "AS-400",
            Description = "Başlangıç ve orta seviye alto saksofon",
            Price = 45000m,
            StockQuantity = 3,
            Brand = "Jean Paul",
            ImageUrl = "https://placehold.co/600x400/0d9488/ffffff?text=Alto+Saxophone",
            InstrumentCategoryId = 5
        },
        new Instrument
        {
            Id = 15,
            Name = "TR-330",
            Description = "Öğrenciler için Si bemol trompet",
            Price = 19500m,
            StockQuantity = 8,
            Brand = "Jupiter",
            ImageUrl = "https://placehold.co/600x400/059669/ffffff?text=Jupiter+Trumpet",
            InstrumentCategoryId = 5
        },
        new Instrument
        {
            Id = 16,
            Name = "Pacific 112V",
            Description = "Başlangıç ve orta seviye elektro gitar",
            Price = 17500m,
            StockQuantity = 7,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/2563eb/ffffff?text=Pacific+112V",
            InstrumentCategoryId = 1
        },
        new Instrument
        {
            Id = 17,
            Name = "GO:KEYS 3",
            Description = "Taşınabilir ve çok sesli dijital klavye",
            Price = 24000m,
            StockQuantity = 6,
            Brand = "Roland",
            ImageUrl = "https://placehold.co/600x400/7c3aed/ffffff?text=Roland+GO+KEYS",
            InstrumentCategoryId = 2
        },
        new Instrument
        {
            Id = 18,
            Name = "Nitro Max Kit",
            Description = "Başlangıç ve orta seviye elektronik davul seti",
            Price = 29500m,
            StockQuantity = 4,
            Brand = "Alesis",
            ImageUrl = "https://placehold.co/600x400/dc2626/ffffff?text=Alesis+Nitro",
            InstrumentCategoryId = 3
        },
        new Instrument
        {
            Id = 19,
            Name = "Student II Violin",
            Description = "Yeni başlayanlar için tam boy keman",
            Price = 13500m,
            StockQuantity = 9,
            Brand = "Stentor",
            ImageUrl = "https://placehold.co/600x400/9333ea/ffffff?text=Stentor+Violin",
            InstrumentCategoryId = 4
        },
        new Instrument
        {
            Id = 20,
            Name = "YTR-2330",
            Description = "Öğrenciler için Si bemol trompet",
            Price = 38500m,
            StockQuantity = 5,
            Brand = "Yamaha",
            ImageUrl = "https://placehold.co/600x400/059669/ffffff?text=Yamaha+Trumpet",
            InstrumentCategoryId = 5
        }
        );
        }
    }
}