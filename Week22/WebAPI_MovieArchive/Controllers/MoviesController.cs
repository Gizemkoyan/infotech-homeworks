using Microsoft.AspNetCore.Mvc;
using WebAPI_MovieArchive.DTOs;
using WebAPI_MovieArchive.Services;

namespace WebAPI_MovieArchive.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public async Task<ActionResult<List<MovieDto>>> GetAll()
    {
        var movies = await _movieService.GetAllAsync();
        return Ok(movies);
    }

    [HttpGet("count")]
    public async Task<ActionResult<int>> GetCount()
    {
        var count = await _movieService.GetCountAsync();
        return Ok(count);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<MovieDto>> GetById(int id)
    {
        var movie = await _movieService.GetByIdAsync(id);

        if (movie == null)
            return NotFound();

        return Ok(movie);
    }

    [HttpPost]
    public async Task<ActionResult<MovieDto>> Create(CreateMovieDto dto)
    {
        var movie = await _movieService.AddAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = movie.Id },
            movie
        );
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, UpdateMovieDto dto)
    {
        var updated = await _movieService.UpdateAsync(id, dto);

        if (!updated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _movieService.DeleteAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}