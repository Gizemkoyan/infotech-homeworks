using WebAPI_MovieArchive.Models.Entities;

namespace WebAPI_MovieArchive.Data;

public interface IMovieRepository
{
    Task<List<Movie>> GetAllAsync();
    Task<Movie?> GetByIdAsync(int id);
    Task<int> GetCountAsync();
    Task<Movie> AddAsync(Movie movie);
    Task<bool> UpdateAsync(Movie movie);
    Task<bool> DeleteAsync(int id);
}