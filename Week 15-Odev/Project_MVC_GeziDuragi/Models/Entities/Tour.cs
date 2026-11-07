namespace Project_MVC_GeziDuragi.Models.Entities;

public class Tour
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quota { get; set; }
    public string ImageUrl { get; set; } = null!;
    public int DurationDays { get; set; }
    public int TourCategoryId { get; set; }
    public TourCategory? TourCategory { get; set; }
}