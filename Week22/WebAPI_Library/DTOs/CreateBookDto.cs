using System.ComponentModel.DataAnnotations;

namespace WebAPI_Library.DTOs;

public class CreateBookDto
{
    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Author { get; set; } = string.Empty;

    [Range(1, int.MaxValue)]
    public int PageCount { get; set; }
}