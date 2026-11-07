using Microsoft.EntityFrameworkCore;
using week13_odev03.Models;

namespace week13_odev03.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<MenuCategory> MenuCategories { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }

   
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory
                {
                    Id = 1,
                    Name = "Çorbalar",
                    Description = "Günlük hazırlanan sıcak çorbalar",
                    DisplayOrder = 1
                },
                new MenuCategory
                {
                    Id = 2,
                    Name = "Ana Yemekler",
                    Description = "Et ve tavuk yemekleri",
                    DisplayOrder = 2
                },
                new MenuCategory
                {
                    Id = 3,
                    Name = "Salatalar",
                    Description = "Taze ve sağlıklı salatalar",
                    DisplayOrder = 3
                },
                new MenuCategory
                {
                    Id = 4,
                    Name = "Tatlılar",
                    Description = "Geleneksel ve sütlü tatlılar",
                    DisplayOrder = 4
                }
            );
            modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem
            {
                Id = 1,
                Name = "Mercimek Çorbası",
                Description = "Geleneksel mercimek çorbası",
                Price = 90.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 15,
                ImageUrl = "/images/mercimek.jpg",
                MenuCategoryId = 1
            },
            new MenuItem
            {
                Id = 2,
                Name = "Ezogelin Çorbası",
                Description = "Baharatlı ezogelin çorbası",
                Price = 95.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 20,
                ImageUrl = "/images/ezogelin.jpg",
                MenuCategoryId = 1
            },
            new MenuItem
            {
                Id = 3,
                Name = "Domates Çorbası",
                Description = "Kaşarlı domates çorbası",
                Price = 85.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 15,
                ImageUrl = "/images/domates.jpg",
                MenuCategoryId = 1
            },
            new MenuItem
            {
                Id = 4,
                Name = "Izgara Köfte",
                Description = "Pilav ve közlenmiş sebzelerle",
                Price = 280.00m,
                IsVegetarian = false,
                PreparationTimeMinutes = 30,
                ImageUrl = "/images/kofte.jpg",
                MenuCategoryId = 2
            },
            new MenuItem
            {
                Id = 5,
                Name = "Tavuk Şiş",
                Description = "Özel soslu ızgara tavuk",
                Price = 240.00m,
                IsVegetarian = false,
                PreparationTimeMinutes = 25,
                ImageUrl = "/images/tavuk.jpg",
                MenuCategoryId = 2
            },
            new MenuItem
            {
                Id = 6,
                Name = "Et Sote",
                Description = "Sebzeli dana eti sote",
                Price = 350.00m,
                IsVegetarian = false,
                PreparationTimeMinutes = 35,
                ImageUrl = "/images/etsote.jpg",
                MenuCategoryId = 2
            },
            new MenuItem
            {
                Id = 7,
                Name = "Çoban Salata",
                Description = "Domates, salatalık ve biber",
                Price = 110.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 10,
                ImageUrl = "/images/coban.jpg",
                MenuCategoryId = 3
            },
            new MenuItem
            {
                Id = 8,
                Name = "Sezar Salata",
                Description = "Marul, kruton ve özel sos",
                Price = 160.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 15,
                ImageUrl = "/images/sezar.jpg",
                MenuCategoryId = 3
            },
            new MenuItem
            {
                Id = 9,
                Name = "Akdeniz Salata",
                Description = "Beyaz peynirli Akdeniz yeşillikleri",
                Price = 140.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 10,
                ImageUrl = "/images/akdeniz.jpg",
                MenuCategoryId = 3
            },
            new MenuItem
            {
                Id = 10,
                Name = "Sütlaç",
                Description = "Fırında geleneksel sütlaç",
                Price = 120.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 20,
                ImageUrl = "/images/sutlac.jpg",
                MenuCategoryId = 4
            },
            new MenuItem
            {
                Id = 11,
                Name = "Kazandibi",
                Description = "Karamelize sütlü tatlı",
                Price = 130.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 20,
                ImageUrl = "/images/kazandibi.jpg",
                MenuCategoryId = 4
            },
            new MenuItem
            {
                Id = 12,
                Name = "Baklava",
                Description = "Antep fıstıklı baklava",
                Price = 190.00m,
                IsVegetarian = true,
                PreparationTimeMinutes = 10,
                ImageUrl = "/images/baklava.jpg",
                MenuCategoryId = 4
            }
        );
        }
}