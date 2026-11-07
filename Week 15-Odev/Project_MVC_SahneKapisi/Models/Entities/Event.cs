namespace Project_MVC_SahneKapisi.Models.Entities;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int AvailableTickets { get; set; }
    public string ImageUrl { get; set; } = null!;
    public DateTime EventDate { get; set; }
    public int EventCategoryId { get; set; }
    public EventCategory? EventCategory { get; set; }
}