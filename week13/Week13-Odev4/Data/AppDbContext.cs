using Microsoft.EntityFrameworkCore;
using week13_odev4.Models;

namespace week13_odev4.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Genre>().HasData(
            new Genre
            {
                Id = 1,
                Name = "Bilim Kurgu",
                Description = "Bilim ve teknoloji temalı filmler"
            },
            new Genre
            {
                Id = 2,
                Name = "Dram",
                Description = "Duygusal ve gerçekçi hikayeler"
            },
            new Genre
            {
                Id = 3,
                Name = "Aksiyon",
                Description = "Macera ve heyecan dolu filmler"
            },
            new Genre
            {
                Id = 4,
                Name = "Komedi",
                Description = "Eğlenceli ve mizah içerikli filmler"
            }
        );
        modelBuilder.Entity<Movie>().HasData(
        new Movie
        {
            Id = 1,
            Title = "Interstellar",
            Director = "Christopher Nolan",
            ReleaseYear = 2014,
            DurationMinutes = 169,
            ImdbRating = 8.7,
            PosterUrl = "/images/interstellar.jpg",
            GenreId = 1
        },
        new Movie
        {
            Id = 2,
            Title = "Inception",
            Director = "Christopher Nolan",
            ReleaseYear = 2010,
            DurationMinutes = 148,
            ImdbRating = 8.8,
            PosterUrl = "/images/inception.jpg",
            GenreId = 1
        },
        new Movie
        {
            Id = 3,
            Title = "The Matrix",
            Director = "Lana Wachowski, Lilly Wachowski",
            ReleaseYear = 1999,
            DurationMinutes = 136,
            ImdbRating = 8.7,
            PosterUrl = "/images/matrix.jpg",
            GenreId = 1
        },
        new Movie
        {
            Id = 4,
            Title = "The Shawshank Redemption",
            Director = "Frank Darabont",
            ReleaseYear = 1994,
            DurationMinutes = 142,
            ImdbRating = 9.3,
            PosterUrl = "/images/shawshank.jpg",
            GenreId = 2
        },
        new Movie
        {
            Id = 5,
            Title = "Forrest Gump",
            Director = "Robert Zemeckis",
            ReleaseYear = 1994,
            DurationMinutes = 142,
            ImdbRating = 8.8,
            PosterUrl = "/images/forrestgump.jpg",
            GenreId = 2
        },
        new Movie
        {
            Id = 6,
            Title = "The Green Mile",
            Director = "Frank Darabont",
            ReleaseYear = 1999,
            DurationMinutes = 189,
            ImdbRating = 8.6,
            PosterUrl = "/images/greenmile.jpg",
            GenreId = 2
        },
        new Movie
        {
            Id = 7,
            Title = "The Dark Knight",
            Director = "Christopher Nolan",
            ReleaseYear = 2008,
            DurationMinutes = 152,
            ImdbRating = 9.0,
            PosterUrl = "/images/darkknight.jpg",
            GenreId = 3
        },
        new Movie
        {
            Id = 8,
            Title = "John Wick",
            Director = "Chad Stahelski",
            ReleaseYear = 2014,
            DurationMinutes = 101,
            ImdbRating = 7.5,
            PosterUrl = "/images/johnwick.jpg",
            GenreId = 3
        },
        new Movie
        {
            Id = 9,
            Title = "Mad Max: Fury Road",
            Director = "George Miller",
            ReleaseYear = 2015,
            DurationMinutes = 120,
            ImdbRating = 8.1,
            PosterUrl = "/images/madmax.jpg",
            GenreId = 3
        },
        new Movie
        {
            Id = 10,
            Title = "The Hangover",
            Director = "Todd Phillips",
            ReleaseYear = 2009,
            DurationMinutes = 100,
            ImdbRating = 7.7,
            PosterUrl = "/images/hangover.jpg",
            GenreId = 4
        },
        new Movie
        {
            Id = 11,
            Title = "Home Alone",
            Director = "Chris Columbus",
            ReleaseYear = 1990,
            DurationMinutes = 103,
            ImdbRating = 7.7,
            PosterUrl = "/images/homealone.jpg",
            GenreId = 4
        },
        new Movie
        {
            Id = 12,
            Title = "The Mask",
            Director = "Chuck Russell",
            ReleaseYear = 1994,
            DurationMinutes = 101,
            ImdbRating = 6.9,
            PosterUrl = "/images/mask.jpg",
            GenreId = 4
        }
    );
    }
}