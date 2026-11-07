using WebAPI_Library.DTOs;

namespace WebAPI_Library.Services;

public interface IBookService
{
    Task<List<BookDto>> GetAllAsync();
    Task<BookDto?> GetByIdAsync(int id);
    Task<int> GetCountAsync();
    Task<BookDto> AddAsync(CreateBookDto dto);
    Task<bool> UpdateAsync(int id, UpdateBookDto dto);
    Task<bool> DeleteAsync(int id);
}