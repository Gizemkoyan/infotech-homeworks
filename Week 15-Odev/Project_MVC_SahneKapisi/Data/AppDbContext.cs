using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_MVC_SahneKapisi.Models.Entities;

namespace Project_MVC_SahneKapisi.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<EventCategory> EventCategories { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }
    public DbSet<TicketOrder> TicketOrders { get; set; }
    public DbSet<TicketOrderItem> TicketOrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Event>()
            .HasOne(e => e.EventCategory)
            .WithMany(c => c.Events)
            .HasForeignKey(e => e.EventCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Basket>()
            .HasOne(b => b.AppUser)
            .WithMany()
            .HasForeignKey(b => b.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BasketItem>()
            .HasOne(bi => bi.Basket)
            .WithMany(b => b.BasketItems)
            .HasForeignKey(bi => bi.BasketId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BasketItem>()
            .HasOne(bi => bi.Event)
            .WithMany()
            .HasForeignKey(bi => bi.EventId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BasketItem>()
            .HasIndex(bi => new { bi.BasketId, bi.EventId })
            .IsUnique();

        modelBuilder.Entity<TicketOrder>()
            .HasOne(to => to.AppUser)
            .WithMany()
            .HasForeignKey(to => to.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TicketOrderItem>()
            .HasOne(toi => toi.TicketOrder)
            .WithMany(to => to.TicketOrderItems)
            .HasForeignKey(toi => toi.TicketOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TicketOrderItem>()
            .HasOne(toi => toi.Event)
            .WithMany()
            .HasForeignKey(toi => toi.EventId)
            .OnDelete(DeleteBehavior.Restrict);

    }

}