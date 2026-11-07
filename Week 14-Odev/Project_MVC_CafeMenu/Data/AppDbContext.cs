
using Microsoft.EntityFrameworkCore;
using Project_MVC_CafeMenu.Models;

namespace Project_MVC_CafeMenu.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LezzetDuragi.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuCategory>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Name)
                .IsRequired();

            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MenuItem>()
                .HasOne(m => m.MenuCategory)
                .WithMany(c => c.MenuItems)
                .HasForeignKey(m => m.MenuCategoryId);
            
            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory
                {
                    Id = 1,
                    Name = "Kahvaltı",
                    Description = "Güne başlangıç lezzetleri"
                },
                new MenuCategory
                {
                    Id = 2,
                    Name = "Ana Yemek",
                    Description = "Doyurucu ana yemekler"
                },
                new MenuCategory
                {
                    Id = 3,
                    Name = "Tatlı",
                    Description = "Ev yapımı tatlılar"
                },
                new MenuCategory
                {
                    Id = 4,
                    Name = "İçecek",
                    Description = "Sıcak ve soğuk içecekler"
                },
                new MenuCategory
                {
                    Id = 5,
                    Name = "Atıştırmalık",
                    Description = "Hafif atıştırmalıklar"
                }
            );
            
                modelBuilder.Entity<MenuItem>().HasData(
                    // Kahvaltı
                    new MenuItem
                    {
                        Id = 1,
                        Name = "Serpme Kahvaltı",
                        Description = "Peynir, zeytin, reçel, yumurta ve sıcak ekmek.",
                        Price = 450,
                        IsAvailable = true,
                        PreparationTimeMinutes = 25,
                        ImageUrl = "https://placehold.co/600x400/FFE4B5/000000?text=Serpme+Kahvalti",
                        MenuCategoryId = 1
                    },
                    new MenuItem
                    {
                        Id = 2,
                        Name = "Menemen",
                        Description = "Domates, biber ve yumurta ile hazırlanır.",
                        Price = 180,
                        IsAvailable = true,
                        PreparationTimeMinutes = 15,
                        ImageUrl = "https://placehold.co/600x400/FFDAB9/000000?text=Menemen",
                        MenuCategoryId = 1
                    },
                    new MenuItem
                    {
                        Id = 3,
                        Name = "Kaşarlı Tost",
                        Description = "Bol kaşarlı, çıtır ekmekli tost.",
                        Price = 140,
                        IsAvailable = true,
                        PreparationTimeMinutes = 10,
                        ImageUrl = "https://placehold.co/600x400/F5DEB3/000000?text=Kasarli+Tost",
                        MenuCategoryId = 1
                    },

                    // Ana Yemek
                    new MenuItem
                    {
                        Id = 4,
                        Name = "Izgara Köfte",
                        Description = "Patates kızartması ve salata ile servis edilir.",
                        Price = 390,
                        IsAvailable = true,
                        PreparationTimeMinutes = 30,
                        ImageUrl = "https://placehold.co/600x400/D2B48C/000000?text=Izgara+Kofte",
                        MenuCategoryId = 2
                    },
                    new MenuItem
                    {
                        Id = 5,
                        Name = "Tavuklu Makarna",
                        Description = "Kremalı sos ve tavuk parçalarıyla hazırlanır.",
                        Price = 320,
                        IsAvailable = true,
                        PreparationTimeMinutes = 20,
                        ImageUrl = "https://placehold.co/600x400/FAEBD7/000000?text=Tavuklu+Makarna",
                        MenuCategoryId = 2
                    },
                    new MenuItem
                    {
                        Id = 6,
                        Name = "Cheeseburger",
                        Description = "Dana köfte, cheddar peyniri ve özel sos.",
                        Price = 350,
                        IsAvailable = false,
                        PreparationTimeMinutes = 25,
                        ImageUrl = "https://placehold.co/600x400/DEB887/000000?text=Cheeseburger",
                        MenuCategoryId = 2
                    },

                    // Tatlı
                    new MenuItem
                    {
                        Id = 7,
                        Name = "San Sebastian Cheesecake",
                        Description = "Kremamsı dokulu, hafif yanık cheesecake.",
                        Price = 240,
                        IsAvailable = true,
                        PreparationTimeMinutes = 5,
                        ImageUrl = "https://placehold.co/600x400/FFF8DC/000000?text=Cheesecake",
                        MenuCategoryId = 3
                    },
                    new MenuItem
                    {
                        Id = 8,
                        Name = "Sufle",
                        Description = "İçi akışkan çikolatalı sıcak tatlı.",
                        Price = 210,
                        IsAvailable = true,
                        PreparationTimeMinutes = 15,
                        ImageUrl = "https://placehold.co/600x400/8B4513/FFFFFF?text=Sufle",
                        MenuCategoryId = 3
                    },
                    new MenuItem
                    {
                        Id = 9,
                        Name = "Sütlaç",
                        Description = "Geleneksel fırın sütlaç.",
                        Price = 160,
                        IsAvailable = true,
                        PreparationTimeMinutes = 5,
                        ImageUrl = "https://placehold.co/600x400/FFFACD/000000?text=Sutlac",
                        MenuCategoryId = 3
                    },

                    // İçecek
                    new MenuItem
                    {
                        Id = 10,
                        Name = "Türk Kahvesi",
                        Description = "Geleneksel yöntemle hazırlanan Türk kahvesi.",
                        Price = 110,
                        IsAvailable = true,
                        PreparationTimeMinutes = 7,
                        ImageUrl = "https://placehold.co/600x400/6F4E37/FFFFFF?text=Turk+Kahvesi",
                        MenuCategoryId = 4
                    },
                    new MenuItem
                    {
                        Id = 11,
                        Name = "Latte",
                        Description = "Espresso ve süt köpüğüyle hazırlanan kahve.",
                        Price = 150,
                        IsAvailable = true,
                        PreparationTimeMinutes = 5,
                        ImageUrl = "https://placehold.co/600x400/C4A484/000000?text=Latte",
                        MenuCategoryId = 4
                    },
                    new MenuItem
                    {
                        Id = 12,
                        Name = "Limonata",
                        Description = "Taze limonlarla hazırlanan ev yapımı limonata.",
                        Price = 130,
                        IsAvailable = false,
                        PreparationTimeMinutes = 5,
                        ImageUrl = "https://placehold.co/600x400/FFF44F/000000?text=Limonata",
                        MenuCategoryId = 4
                    },

                    // Atıştırmalık
                    new MenuItem
                    {
                        Id = 13,
                        Name = "Patates Kızartması",
                        Description = "Çıtır patates kızartması ve özel sos.",
                        Price = 160,
                        IsAvailable = true,
                        PreparationTimeMinutes = 12,
                        ImageUrl = "https://placehold.co/600x400/FFD700/000000?text=Patates",
                        MenuCategoryId = 5
                    },
                    new MenuItem
                    {
                        Id = 14,
                        Name = "Soğan Halkası",
                        Description = "Çıtır kaplamalı soğan halkaları.",
                        Price = 170,
                        IsAvailable = true,
                        PreparationTimeMinutes = 10,
                        ImageUrl = "https://placehold.co/600x400/F4A460/000000?text=Sogan+Halkasi",
                        MenuCategoryId = 5
                    },
                    new MenuItem
                    {
                        Id = 15,
                        Name = "Nachos",
                        Description = "Mısır cipsi, cheddar sos ve jalapeno.",
                        Price = 220,
                        IsAvailable = true,
                        PreparationTimeMinutes = 10,
                        ImageUrl = "https://placehold.co/600x400/FFA500/000000?text=Nachos",
                        MenuCategoryId = 5
                    }
                );
            
        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem
            {
                Id = 16,
                Name = "Pankek",
                Description = "Bal ve mevsim meyveleriyle servis edilen pankek.",
                Price = 220,
                IsAvailable = true,
                PreparationTimeMinutes = 15,
                ImageUrl = "https://placehold.co/600x400/FFE4B5/000000?text=Pankek",
                MenuCategoryId = 1
            },
            new MenuItem
            {
                Id = 17,
                Name = "Tavuk Schnitzel",
                Description = "Çıtır tavuk, patates püresi ve salata.",
                Price = 360,
                IsAvailable = true,
                PreparationTimeMinutes = 25,
                ImageUrl = "https://placehold.co/600x400/DEB887/000000?text=Schnitzel",
                MenuCategoryId = 2
            },
            new MenuItem
            {
                Id = 18,
                Name = "Tiramisu",
                Description = "Kahve aromalı, mascarpone kremalı İtalyan tatlısı.",
                Price = 230,
                IsAvailable = true,
                PreparationTimeMinutes = 5,
                ImageUrl = "https://placehold.co/600x400/D2B48C/000000?text=Tiramisu",
                MenuCategoryId = 3
            },
            new MenuItem
            {
                Id = 19,
                Name = "Iced Americano",
                Description = "Buzla servis edilen soğuk espresso kahvesi.",
                Price = 145,
                IsAvailable = true,
                PreparationTimeMinutes = 5,
                ImageUrl = "https://placehold.co/600x400/6F4E37/FFFFFF?text=Iced+Americano",
                MenuCategoryId = 4
            },
            new MenuItem
            {
                Id = 20,
                Name = "Mozzarella Sticks",
                Description = "Çıtır kaplamalı mozzarella peynir çubukları.",
                Price = 195,
                IsAvailable = false,
                PreparationTimeMinutes = 12,
                ImageUrl = "https://placehold.co/600x400/FFD700/000000?text=Mozzarella+Sticks",
                MenuCategoryId = 5
            }
        );

        }

    }
}
