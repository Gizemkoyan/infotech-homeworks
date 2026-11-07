using WebAPI_MovieArchive.DTOs;

namespace WebAPI_MovieArchive.Services;

public interface IMovieService
{
    Task<List<MovieDto>> GetAllAsync();
    Task<MovieDto?> GetByIdAsync(int id);
    Task<int> GetCountAsync();
    Task<MovieDto> AddAsync(CreateMovieDto dto);
    Task<bool> UpdateAsync(int id, UpdateMovieDto dto);
    Task<bool> DeleteAsync(int id);
}