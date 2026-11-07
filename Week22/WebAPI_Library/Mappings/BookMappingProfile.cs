using AutoMapper;
using WebAPI_Library.DTOs;
using WebAPI_Library.Models.Entities;

namespace WebAPI_Library.Mappings;

public class BookMappingProfile : Profile
{
    public BookMappingProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
    }
}