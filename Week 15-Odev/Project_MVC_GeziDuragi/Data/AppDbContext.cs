using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_MVC_GeziDuragi.Models.Entities;

namespace Project_MVC_GeziDuragi.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TourCategory> TourCategories { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationItem> ReservationItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tour>()
            .HasOne(t => t.TourCategory)
            .WithMany(tc => tc.Tours)
            .HasForeignKey(t => t.TourCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Cart>()
            .HasOne(c => c.AppUser)
            .WithMany()
            .HasForeignKey(c => c.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.Cart)
            .WithMany(c => c.CartItems)
            .HasForeignKey(ci => ci.CartId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.Tour)
            .WithMany()
            .HasForeignKey(ci => ci.TourId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CartItem>()
            .HasIndex(ci => new { ci.CartId, ci.TourId })
            .IsUnique();

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.AppUser)
            .WithMany()
            .HasForeignKey(r => r.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ReservationItem>()
            .HasOne(ri => ri.Reservation)
            .WithMany(r => r.ReservationItems)
            .HasForeignKey(ri => ri.ReservationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ReservationItem>()
            .HasOne(ri => ri.Tour)
            .WithMany()
            .HasForeignKey(ri => ri.TourId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}