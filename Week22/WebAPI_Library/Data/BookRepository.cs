using Microsoft.EntityFrameworkCore;
using WebAPI_Library.Models.Entities;

namespace WebAPI_Library.Data;

public class BookRepository : IBookRepository
{
    private readonly LibraryDbContext _context;

    public BookRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await _context.Books.AsNoTracking().ToListAsync();
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
        return await _context.Books.AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<int> GetCountAsync()
    {
        return await _context.Books.CountAsync();
    }

    public async Task<Book> AddAsync(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return book;
    }

    public async Task<bool> UpdateAsync(Book book)
    {
        var existingBook = await _context.Books.FindAsync(book.Id);

        if (existingBook == null)
            return false;

        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.PageCount = book.PageCount;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if (book == null)
            return false;

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        return true;
    }
}