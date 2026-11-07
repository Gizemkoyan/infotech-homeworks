using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_MVC_GeziDuragi.Models.Entities;

namespace Project_MVC_GeziDuragi.Data;

public static class DbInitializer
{
    public static async Task SeedAsync(
        AppDbContext context,
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        if (!await context.TourCategories.AnyAsync())
        {
            var categories = new List<TourCategory>
            {
                new() { Name = "Kültür", Description = "Müze, tarihi yer, şehir turları" },
                new() { Name = "Doğa", Description = "Trekking, kamp, doğa yürüyüşü" },
                new() { Name = "Deniz", Description = "Kıyı ve ada turları" },
                new() { Name = "Gastronomi", Description = "Yemek ve lezzet turları" },
                new() { Name = "Macera", Description = "Rafting, paraşüt, ekstrem aktiviteler" }
            };

            await context.TourCategories.AddRangeAsync(categories);
            await context.SaveChangesAsync();
        }

        if (!await context.Tours.AnyAsync())
        {
            var kultur = await context.TourCategories
                .FirstAsync(c => c.Name == "Kültür");

            var doga = await context.TourCategories
                .FirstAsync(c => c.Name == "Doğa");

            var deniz = await context.TourCategories
                .FirstAsync(c => c.Name == "Deniz");

            var gastronomi = await context.TourCategories
                .FirstAsync(c => c.Name == "Gastronomi");

            var macera = await context.TourCategories
                .FirstAsync(c => c.Name == "Macera");

            var tours = new List<Tour>
            {
                // Kültür
                new()
                {
                    Name = "İstanbul Tarih Turu",
                    Description = "İstanbul'un tarihi bölgelerini keşfetme turu",
                    Price = 900m,
                    Quota = 30,
                    ImageUrl = "https://placehold.co/400x400?text=Istanbul+Turu",
                    DurationDays = 1,
                    TourCategoryId = kultur.Id
                },
                new()
                {
                    Name = "Kapadokya Kültür Turu",
                    Description = "Kapadokya'nın tarihi ve kültürel noktalarını keşfetme turu",
                    Price = 3200m,
                    Quota = 25,
                    ImageUrl = "https://placehold.co/400x400?text=Kapadokya",
                    DurationDays = 3,
                    TourCategoryId = kultur.Id
                },
                new()
                {
                    Name = "Efes Antik Kent Turu",
                    Description = "Efes Antik Kenti ve çevresini keşfetme turu",
                    Price = 1400m,
                    Quota = 35,
                    ImageUrl = "https://placehold.co/400x400?text=Efes",
                    DurationDays = 1,
                    TourCategoryId = kultur.Id
                },

                // Doğa
                new()
                {
                    Name = "Kaz Dağları Trekking",
                    Description = "Kaz Dağları'nda doğa yürüyüşü",
                    Price = 1600m,
                    Quota = 20,
                    ImageUrl = "https://placehold.co/400x400?text=Kaz+Daglari",
                    DurationDays = 2,
                    TourCategoryId = doga.Id
                },
                new()
                {
                    Name = "Yedigöller Doğa Turu",
                    Description = "Yedigöller Milli Parkı doğa gezisi",
                    Price = 1200m,
                    Quota = 30,
                    ImageUrl = "https://placehold.co/400x400?text=Yedigoller",
                    DurationDays = 1,
                    TourCategoryId = doga.Id
                },
                new()
                {
                    Name = "Karadeniz Yayla Turu",
                    Description = "Karadeniz yaylalarını keşfetme turu",
                    Price = 4800m,
                    Quota = 25,
                    ImageUrl = "https://placehold.co/400x400?text=Karadeniz",
                    DurationDays = 5,
                    TourCategoryId = doga.Id
                },

                // Deniz
                new()
                {
                    Name = "Bozcaada Turu",
                    Description = "Bozcaada kıyı ve ada turu",
                    Price = 1800m,
                    Quota = 35,
                    ImageUrl = "https://placehold.co/400x400?text=Bozcaada",
                    DurationDays = 2,
                    TourCategoryId = deniz.Id
                },
                new()
                {
                    Name = "Fethiye Tekne Turu",
                    Description = "Fethiye koylarını keşfetme tekne turu",
                    Price = 1500m,
                    Quota = 40,
                    ImageUrl = "https://placehold.co/400x400?text=Fethiye",
                    DurationDays = 1,
                    TourCategoryId = deniz.Id
                },
                new()
                {
                    Name = "Kaş Kekova Turu",
                    Description = "Kaş ve Kekova kıyılarını keşfetme turu",
                    Price = 2600m,
                    Quota = 30,
                    ImageUrl = "https://placehold.co/400x400?text=Kas+Kekova",
                    DurationDays = 2,
                    TourCategoryId = deniz.Id
                },

                // Gastronomi
                new()
                {
                    Name = "Gaziantep Lezzet Turu",
                    Description = "Gaziantep mutfağını keşfetme turu",
                    Price = 2900m,
                    Quota = 25,
                    ImageUrl = "https://placehold.co/400x400?text=Gaziantep",
                    DurationDays = 2,
                    TourCategoryId = gastronomi.Id
                },
                new()
                {
                    Name = "Hatay Gastronomi Turu",
                    Description = "Hatay'ın yöresel lezzetlerini keşfetme turu",
                    Price = 2700m,
                    Quota = 25,
                    ImageUrl = "https://placehold.co/400x400?text=Hatay",
                    DurationDays = 2,
                    TourCategoryId = gastronomi.Id
                },
                new()
                {
                    Name = "Ege Lezzet Rotası",
                    Description = "Ege mutfağının yerel tatlarını keşfetme turu",
                    Price = 3400m,
                    Quota = 30,
                    ImageUrl = "https://placehold.co/400x400?text=Ege+Lezzet",
                    DurationDays = 3,
                    TourCategoryId = gastronomi.Id
                },

                // Macera
                new()
                {
                    Name = "Köprülü Kanyon Rafting",
                    Description = "Köprülü Kanyon'da rafting deneyimi",
                    Price = 1700m,
                    Quota = 20,
                    ImageUrl = "https://placehold.co/400x400?text=Rafting",
                    DurationDays = 1,
                    TourCategoryId = macera.Id
                },
                new()
                {
                    Name = "Fethiye Yamaç Paraşütü",
                    Description = "Babadağ'dan yamaç paraşütü deneyimi",
                    Price = 3500m,
                    Quota = 15,
                    ImageUrl = "https://placehold.co/400x400?text=Parasut",
                    DurationDays = 1,
                    TourCategoryId = macera.Id
                },
                new()
                {
                    Name = "Kanyon Macera Turu",
                    Description = "Doğa içinde ekstrem aktiviteler ve kanyon yürüyüşü",
                    Price = 2200m,
                    Quota = 20,
                    ImageUrl = "https://placehold.co/400x400?text=Macera",
                    DurationDays = 2,
                    TourCategoryId = macera.Id
                }
            };

            await context.Tours.AddRangeAsync(tours);
            await context.SaveChangesAsync();
        }

        string[] roles = { "Admin", "Customer" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        var adminEmail = "admin@geziduragi.local";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            adminUser = new AppUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FullName = "GeziDuragi Admin",
                EmailConfirmed = true
            };

            var adminResult = await userManager.CreateAsync(
                adminUser,
                "Admin123!"
            );

            if (adminResult.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }

        var customerEmail = "musteri@geziduragi.local";
        var customerUser = await userManager.FindByEmailAsync(customerEmail);

        if (customerUser == null)
        {
            customerUser = new AppUser
            {
                UserName = customerEmail,
                Email = customerEmail,
                FullName = "GeziDuragi Musteri",
                EmailConfirmed = true
            };

            var customerResult = await userManager.CreateAsync(
                customerUser,
                "Customer123!"
            );

            if (customerResult.Succeeded)
            {
                await userManager.AddToRoleAsync(customerUser, "Customer");
            }
        }
    }
}