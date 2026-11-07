using AutoMapper;
using WebAPI_MovieArchive.Data;
using WebAPI_MovieArchive.DTOs;
using WebAPI_MovieArchive.Models.Entities;

namespace WebAPI_MovieArchive.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieService(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public async Task<List<MovieDto>> GetAllAsync()
    {
        var movies = await _movieRepository.GetAllAsync();
        return _mapper.Map<List<MovieDto>>(movies);
    }

    public async Task<MovieDto?> GetByIdAsync(int id)
    {
        var movie = await _movieRepository.GetByIdAsync(id);

        if (movie == null)
            return null;

        return _mapper.Map<MovieDto>(movie);
    }

    public async Task<int> GetCountAsync()
    {
        return await _movieRepository.GetCountAsync();
    }

    public async Task<MovieDto> AddAsync(CreateMovieDto dto)
    {
        var movie = _mapper.Map<Movie>(dto);

        var createdMovie = await _movieRepository.AddAsync(movie);

        return _mapper.Map<MovieDto>(createdMovie);
    }

    public async Task<bool> UpdateAsync(int id, UpdateMovieDto dto)
    {
        var movie = _mapper.Map<Movie>(dto);
        movie.Id = id;

        return await _movieRepository.UpdateAsync(movie);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _movieRepository.DeleteAsync(id);
    }
}