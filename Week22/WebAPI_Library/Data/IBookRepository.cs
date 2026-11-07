using WebAPI_Library.Models.Entities;

namespace WebAPI_Library.Data;

public interface IBookRepository
{
    Task<List<Book>> GetAllAsync();
    Task<Book?> GetByIdAsync(int id);
    Task<int> GetCountAsync();
    Task<Book> AddAsync(Book book);
    Task<bool> UpdateAsync(Book book);
    Task<bool> DeleteAsync(int id);
}