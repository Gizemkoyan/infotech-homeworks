namespace week13_odev4.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public int DurationMinutes { get; set; }
    public double ImdbRating { get; set; }
    public string PosterUrl { get; set; } = string.Empty;

    public int GenreId { get; set; }
    public Genre Genre { get; set; } = null!;
}