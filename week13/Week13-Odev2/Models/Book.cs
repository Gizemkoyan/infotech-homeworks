
namespace Week13_Odev2.Models;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string ISBN { get; set; } = string.Empty;

    public int PageCount { get; set; }

    public int PublishedYear { get; set; }

    public int StockCount { get; set; }

    public string CoverImageUrl { get; set; } = string.Empty;

    public int AuthorId { get; set; }

    public Author Author { get; set; } = null!;
}
