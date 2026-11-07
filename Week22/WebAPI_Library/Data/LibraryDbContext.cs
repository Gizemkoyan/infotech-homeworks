using Microsoft.EntityFrameworkCore;
using WebAPI_Library.Models.Entities;

namespace WebAPI_Library.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", PageCount = 160 },
            new Book { Id = 2, Title = "Tutunamayanlar", Author = "Oğuz Atay", PageCount = 724 },
            new Book { Id = 3, Title = "İnce Memed", Author = "Yaşar Kemal", PageCount = 436 },
            new Book { Id = 4, Title = "Saatleri Ayarlama Enstitüsü", Author = "Ahmet Hamdi Tanpınar", PageCount = 382 },
            new Book { Id = 5, Title = "1984", Author = "George Orwell", PageCount = 352 },
            new Book { Id = 6, Title = "Suç ve Ceza", Author = "Fyodor Dostoyevski", PageCount = 687 },
            new Book { Id = 7, Title = "Sefiller", Author = "Victor Hugo", PageCount = 1724 },
            new Book { Id = 8, Title = "Simyacı", Author = "Paulo Coelho", PageCount = 184 }
        );
    }
}