
using Microsoft.EntityFrameworkCore;
using Week13_Odev1.Models;

namespace Week13_Odev1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Oda tipleri
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType
            {
                Id = 1,
                Name = "Standard",
                Description = "Standart oda",
                PricePerNight = 1500,
                Capacity = 2
            },
            new RoomType
            {
                Id = 2,
                Name = "Deluxe",
                Description = "Geniş ve konforlu oda",
                PricePerNight = 2500,
                Capacity = 3
            },
            new RoomType
            {
                Id = 3,
                Name = "Suite",
                Description = "Lüks süit oda",
                PricePerNight = 4500,
                Capacity = 4
            }
        );

        // Odalar
        modelBuilder.Entity<Room>().HasData(
            new Room { Id = 1, RoomNumber = "101", Floor = 1, IsAvailable = true, ImageUrl = "/images/101.jpg", RoomTypeId = 1 },
            new Room { Id = 2, RoomNumber = "102", Floor = 1, IsAvailable = true, ImageUrl = "/images/102.jpg", RoomTypeId = 1 },
            new Room { Id = 3, RoomNumber = "103", Floor = 1, IsAvailable = false, ImageUrl = "/images/103.jpg", RoomTypeId = 1 },
            new Room { Id = 4, RoomNumber = "201", Floor = 2, IsAvailable = true, ImageUrl = "/images/201.jpg", RoomTypeId = 2 },
            new Room { Id = 5, RoomNumber = "202", Floor = 2, IsAvailable = false, ImageUrl = "/images/202.jpg", RoomTypeId = 2 },
            new Room { Id = 6, RoomNumber = "203", Floor = 2, IsAvailable = true, ImageUrl = "/images/203.jpg", RoomTypeId = 2 },
            new Room { Id = 7, RoomNumber = "301", Floor = 3, IsAvailable = true, ImageUrl = "/images/301.jpg", RoomTypeId = 3 },
            new Room { Id = 8, RoomNumber = "302", Floor = 3, IsAvailable = false, ImageUrl = "/images/302.jpg", RoomTypeId = 3 }
        );
    }
}
