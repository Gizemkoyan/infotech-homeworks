using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_MVC_SahneKapisi.Models.Entities;

namespace Project_MVC_SahneKapisi.Data;

public static class DbInitializer
{
    public static async Task SeedAsync(
        AppDbContext context,
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        if (!await context.EventCategories.AnyAsync())
        {
            var categories = new List<EventCategory>
            {
                new() { Name = "Konser", Description = "Canlı müzik etkinlikleri" },
                new() { Name = "Tiyatro", Description = "Sahne oyunları" },
                new() { Name = "Festival", Description = "Açık hava ve çok günlük festivaller" },
                new() { Name = "Stand-up", Description = "Komedi gösterileri" },
                new() { Name = "Çocuk", Description = "Çocuklara yönelik etkinlikler" },
                new() { Name = "Klasik", Description = "Opera, bale, klasik müzik" }
            };

            await context.EventCategories.AddRangeAsync(categories);
            await context.SaveChangesAsync();
        }

        if (!await context.Events.AnyAsync())
        {
            var konser = await context.EventCategories
                .FirstAsync(c => c.Name == "Konser");

            var tiyatro = await context.EventCategories
                .FirstAsync(c => c.Name == "Tiyatro");

            var festival = await context.EventCategories
                .FirstAsync(c => c.Name == "Festival");

            var standUp = await context.EventCategories
                .FirstAsync(c => c.Name == "Stand-up");

            var cocuk = await context.EventCategories
                .FirstAsync(c => c.Name == "Çocuk");

            var klasik = await context.EventCategories
                .FirstAsync(c => c.Name == "Klasik");

            var events = new List<Event>
            {
                // Konser
                new()
                {
                    Name = "Rock Gecesi",
                    Description = "Canlı rock müzik konseri",
                    Price = 750m,
                    AvailableTickets = 500,
                    ImageUrl = "https://placehold.co/400x400?text=Rock+Gecesi",
                    EventDate = new DateTime(2026, 10, 10, 20, 0, 0),
                    EventCategoryId = konser.Id
                },
                new()
                {
                    Name = "Jazz Gecesi",
                    Description = "Canlı jazz performansı",
                    Price = 600m,
                    AvailableTickets = 300,
                    ImageUrl = "https://placehold.co/400x400?text=Jazz+Gecesi",
                    EventDate = new DateTime(2026, 10, 20, 21, 0, 0),
                    EventCategoryId = konser.Id
                },
                new()
                {
                    Name = "Akustik Gece",
                    Description = "Akustik müzik konseri",
                    Price = 500m,
                    AvailableTickets = 250,
                    ImageUrl = "https://placehold.co/400x400?text=Akustik+Gece",
                    EventDate = new DateTime(2026, 11, 5, 20, 30, 0),
                    EventCategoryId = konser.Id
                },

                // Tiyatro
                new()
                {
                    Name = "Bir Yaz Gecesi",
                    Description = "İki perdelik tiyatro oyunu",
                    Price = 450m,
                    AvailableTickets = 200,
                    ImageUrl = "https://placehold.co/400x400?text=Bir+Yaz+Gecesi",
                    EventDate = new DateTime(2026, 9, 15, 20, 0, 0),
                    EventCategoryId = tiyatro.Id
                },
                new()
                {
                    Name = "Son Perde",
                    Description = "Dram türünde sahne oyunu",
                    Price = 400m,
                    AvailableTickets = 180,
                    ImageUrl = "https://placehold.co/400x400?text=Son+Perde",
                    EventDate = new DateTime(2026, 10, 3, 19, 30, 0),
                    EventCategoryId = tiyatro.Id
                },
                new()
                {
                    Name = "Komşu Köyün Delisi",
                    Description = "Komedi türünde tiyatro oyunu",
                    Price = 425m,
                    AvailableTickets = 220,
                    ImageUrl = "https://placehold.co/400x400?text=Komedi+Oyunu",
                    EventDate = new DateTime(2026, 11, 12, 20, 0, 0),
                    EventCategoryId = tiyatro.Id
                },

                // Festival
                new()
                {
                    Name = "Yaz Festivali",
                    Description = "Açık hava müzik festivali",
                    Price = 1200m,
                    AvailableTickets = 1500,
                    ImageUrl = "https://placehold.co/400x400?text=Yaz+Festivali",
                    EventDate = new DateTime(2026, 9, 5, 14, 0, 0),
                    EventCategoryId = festival.Id
                },
                new()
                {
                    Name = "Sokak Lezzetleri Festivali",
                    Description = "Yemek ve müzik festivali",
                    Price = 350m,
                    AvailableTickets = 1000,
                    ImageUrl = "https://placehold.co/400x400?text=Lezzet+Festivali",
                    EventDate = new DateTime(2026, 9, 26, 12, 0, 0),
                    EventCategoryId = festival.Id
                },
                new()
                {
                    Name = "Sonbahar Festivali",
                    Description = "Müzik ve sanat festivali",
                    Price = 900m,
                    AvailableTickets = 1200,
                    ImageUrl = "https://placehold.co/400x400?text=Sonbahar+Festivali",
                    EventDate = new DateTime(2026, 10, 17, 13, 0, 0),
                    EventCategoryId = festival.Id
                },

                // Stand-up
                new()
                {
                    Name = "Kahkaha Gecesi",
                    Description = "Tek kişilik stand-up gösterisi",
                    Price = 500m,
                    AvailableTickets = 300,
                    ImageUrl = "https://placehold.co/400x400?text=Kahkaha+Gecesi",
                    EventDate = new DateTime(2026, 9, 18, 21, 0, 0),
                    EventCategoryId = standUp.Id
                },
                new()
                {
                    Name = "Mikrofon Bende",
                    Description = "Yeni nesil stand-up gösterisi",
                    Price = 450m,
                    AvailableTickets = 280,
                    ImageUrl = "https://placehold.co/400x400?text=Mikrofon+Bende",
                    EventDate = new DateTime(2026, 10, 8, 20, 30, 0),
                    EventCategoryId = standUp.Id
                },
                new()
                {
                    Name = "Gülmek Serbest",
                    Description = "Komedi ve stand-up gecesi",
                    Price = 475m,
                    AvailableTickets = 320,
                    ImageUrl = "https://placehold.co/400x400?text=Gulmek+Serbest",
                    EventDate = new DateTime(2026, 11, 20, 21, 0, 0),
                    EventCategoryId = standUp.Id
                },

                // Çocuk
                new()
                {
                    Name = "Masal Dünyası",
                    Description = "Çocuklar için interaktif sahne gösterisi",
                    Price = 250m,
                    AvailableTickets = 200,
                    ImageUrl = "https://placehold.co/400x400?text=Masal+Dunyasi",
                    EventDate = new DateTime(2026, 9, 12, 13, 0, 0),
                    EventCategoryId = cocuk.Id
                },
                new()
                {
                    Name = "Minik Kaşifler",
                    Description = "Eğitici çocuk tiyatrosu",
                    Price = 225m,
                    AvailableTickets = 180,
                    ImageUrl = "https://placehold.co/400x400?text=Minik+Kasifler",
                    EventDate = new DateTime(2026, 10, 24, 14, 0, 0),
                    EventCategoryId = cocuk.Id
                },
                new()
                {
                    Name = "Renkli Orman",
                    Description = "Müzikli çocuk gösterisi",
                    Price = 275m,
                    AvailableTickets = 220,
                    ImageUrl = "https://placehold.co/400x400?text=Renkli+Orman",
                    EventDate = new DateTime(2026, 11, 7, 13, 30, 0),
                    EventCategoryId = cocuk.Id
                },

                // Klasik
                new()
                {
                    Name = "Kuğu Gölü",
                    Description = "Klasik bale gösterisi",
                    Price = 950m,
                    AvailableTickets = 350,
                    ImageUrl = "https://placehold.co/400x400?text=Kugu+Golu",
                    EventDate = new DateTime(2026, 9, 30, 20, 0, 0),
                    EventCategoryId = klasik.Id
                },
                new()
                {
                    Name = "Senfoni Gecesi",
                    Description = "Senfoni orkestrası konseri",
                    Price = 850m,
                    AvailableTickets = 400,
                    ImageUrl = "https://placehold.co/400x400?text=Senfoni+Gecesi",
                    EventDate = new DateTime(2026, 10, 28, 20, 0, 0),
                    EventCategoryId = klasik.Id
                },
                new()
                {
                    Name = "Opera Gecesi",
                    Description = "Klasik opera performansı",
                    Price = 1000m,
                    AvailableTickets = 300,
                    ImageUrl = "https://placehold.co/400x400?text=Opera+Gecesi",
                    EventDate = new DateTime(2026, 11, 28, 20, 0, 0),
                    EventCategoryId = klasik.Id
                }
            };

            await context.Events.AddRangeAsync(events);
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

        var adminEmail = "admin@sahnekapisi.local";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            adminUser = new AppUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FullName = "SahneKapisi Admin",
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

        var customerEmail = "musteri@sahnekapisi.local";
        var customerUser = await userManager.FindByEmailAsync(customerEmail);

        if (customerUser == null)
        {
            customerUser = new AppUser
            {
                UserName = customerEmail,
                Email = customerEmail,
                FullName = "SahneKapisi Musteri",
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