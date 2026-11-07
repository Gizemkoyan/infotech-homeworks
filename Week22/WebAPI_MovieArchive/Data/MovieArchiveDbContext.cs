using Microsoft.EntityFrameworkCore;
using WebAPI_MovieArchive.Models.Entities;

namespace WebAPI_MovieArchive.Data;

public class MovieArchiveDbContext : DbContext
{
    public MovieArchiveDbContext(DbContextOptions<MovieArchiveDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseYear = 1994 },
            new Movie { Id = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = 1972 },
            new Movie { Id = 3, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 },
            new Movie { Id = 4, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 },
            new Movie { Id = 5, Title = "Forrest Gump", Director = "Robert Zemeckis", ReleaseYear = 1994 },
            new Movie { Id = 6, Title = "Inception", Director = "Christopher Nolan", ReleaseYear = 2010 },
            new Movie { Id = 7, Title = "Interstellar", Director = "Christopher Nolan", ReleaseYear = 2014 },
            new Movie { Id = 8, Title = "Parasite", Director = "Bong Joon-ho", ReleaseYear = 2019 }
        );
    }
}