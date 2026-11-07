using AutoMapper;
using WebAPI_MovieArchive.DTOs;
using WebAPI_MovieArchive.Models.Entities;

namespace WebAPI_MovieArchive.Mappings;

public class MovieMappingProfile : Profile
{
    public MovieMappingProfile()
    {
        CreateMap<Movie, MovieDto>();
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
    }
}