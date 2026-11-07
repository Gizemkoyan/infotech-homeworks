using AutoMapper;
using WebAPI_Library.Data;
using WebAPI_Library.DTOs;
using WebAPI_Library.Models.Entities;

namespace WebAPI_Library.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookDto>> GetAllAsync()
    {
        var books = await _bookRepository.GetAllAsync();
        return _mapper.Map<List<BookDto>>(books);
    }

    public async Task<BookDto?> GetByIdAsync(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id);

        if (book == null)
            return null;

        return _mapper.Map<BookDto>(book);
    }

    public async Task<int> GetCountAsync()
    {
        return await _bookRepository.GetCountAsync();
    }

    public async Task<BookDto> AddAsync(CreateBookDto dto)
    {
        var book = _mapper.Map<Book>(dto);
        var addedBook = await _bookRepository.AddAsync(book);

        return _mapper.Map<BookDto>(addedBook);
    }

    public async Task<bool> UpdateAsync(int id, UpdateBookDto dto)
    {
        var book = _mapper.Map<Book>(dto);
        book.Id = id;

        return await _bookRepository.UpdateAsync(book);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _bookRepository.DeleteAsync(id);
    }
}