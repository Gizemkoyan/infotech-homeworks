using Microsoft.EntityFrameworkCore;
using WebAPI_MovieArchive.Models.Entities;

namespace WebAPI_MovieArchive.Data;

public class MovieRepository : IMovieRepository
{
    private readonly MovieArchiveDbContext _context;

    public MovieRepository(MovieArchiveDbContext context)
    {
        _context = context;
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _context.Movies.AsNoTracking().ToListAsync();
    }

    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task<int> GetCountAsync()
    {
        return await _context.Movies.CountAsync();
    }

    public async Task<Movie> AddAsync(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();
        return movie;
    }

    public async Task<bool> UpdateAsync(Movie movie)
    {
        var existingMovie = await _context.Movies.FindAsync(movie.Id);

        if (existingMovie == null)
            return false;

        existingMovie.Title = movie.Title;
        existingMovie.Director = movie.Director;
        existingMovie.ReleaseYear = movie.ReleaseYear;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
            return false;

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return true;
    }
}