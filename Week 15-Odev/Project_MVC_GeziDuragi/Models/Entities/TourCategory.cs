namespace Project_MVC_GeziDuragi.Models.Entities;

public class TourCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<Tour> Tours { get; set; } = new List<Tour>();
}