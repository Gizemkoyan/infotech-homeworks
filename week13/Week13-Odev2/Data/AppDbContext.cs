
using Microsoft.EntityFrameworkCore;
using Week13_Odev2.Models;

namespace Week13_Odev2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Yazarlar
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = 1,
                FirstName = "Sabahattin",
                LastName = "Ali",
                Nationality = "Türk",
                BirthYear = 1907
            },
            new Author
            {
                Id = 2,
                FirstName = "George",
                LastName = "Orwell",
                Nationality = "İngiliz",
                BirthYear = 1903
            },
            new Author
            {
                Id = 3,
                FirstName = "Fyodor",
                LastName = "Dostoyevski",
                Nationality = "Rus",
                BirthYear = 1821
            },
            new Author
            {
                Id = 4,
                FirstName = "Stefan",
                LastName = "Zweig",
                Nationality = "Avusturyalı",
                BirthYear = 1881
            }
        );

        // Kitaplar
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "Kürk Mantolu Madonna",
                ISBN = "9789753638029",
                PageCount = 160,
                PublishedYear = 1943,
                StockCount = 12,
                CoverImageUrl = "/images/book1.jpg",
                AuthorId = 1
            },
            new Book
            {
                Id = 2,
                Title = "Kuyucaklı Yusuf",
                ISBN = "9789750800016",
                PageCount = 220,
                PublishedYear = 1937,
                StockCount = 8,
                CoverImageUrl = "/images/book2.jpg",
                AuthorId = 1
            },
            new Book
            {
                Id = 3,
                Title = "İçimizdeki Şeytan",
                ISBN = "9789753638036",
                PageCount = 256,
                PublishedYear = 1940,
                StockCount = 10,
                CoverImageUrl = "/images/book3.jpg",
                AuthorId = 1
            },
            new Book
            {
                Id = 4,
                Title = "1984",
                ISBN = "9780451524935",
                PageCount = 328,
                PublishedYear = 1949,
                StockCount = 15,
                CoverImageUrl = "/images/book4.jpg",
                AuthorId = 2
            },
            new Book
            {
                Id = 5,
                Title = "Hayvan Çiftliği",
                ISBN = "9780451526342",
                PageCount = 112,
                PublishedYear = 1945,
                StockCount = 20,
                CoverImageUrl = "/images/book5.jpg",
                AuthorId = 2
            },
            new Book
            {
                Id = 6,
                Title = "Suç ve Ceza",
                ISBN = "9780140449136",
                PageCount = 671,
                PublishedYear = 1866,
                StockCount = 7,
                CoverImageUrl = "/images/book6.jpg",
                AuthorId = 3
            },
            new Book
            {
                Id = 7,
                Title = "Karamazov Kardeşler",
                ISBN = "9780374528379",
                PageCount = 824,
                PublishedYear = 1880,
                StockCount = 5,
                CoverImageUrl = "/images/book7.jpg",
                AuthorId = 3
            },
            new Book
            {
                Id = 8,
                Title = "Beyaz Geceler",
                ISBN = "9780486469736",
                PageCount = 128,
                PublishedYear = 1848,
                StockCount = 11,
                CoverImageUrl = "/images/book8.jpg",
                AuthorId = 3
            },
            new Book
            {
                Id = 9,
                Title = "Satranç",
                ISBN = "9789750738609",
                PageCount = 80,
                PublishedYear = 1942,
                StockCount = 18,
                CoverImageUrl = "/images/book9.jpg",
                AuthorId = 4
            },
            new Book
            {
                Id = 10,
                Title = "Bilinmeyen Bir Kadının Mektubu",
                ISBN = "9786053320487",
                PageCount = 72,
                PublishedYear = 1922,
                StockCount = 9,
                CoverImageUrl = "/images/book10.jpg",
                AuthorId = 4
            }
        );
    }
}
