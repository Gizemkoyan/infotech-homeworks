namespace Project_MVC_SahneKapisi.Models.Entities;

public class EventCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<Event> Events { get; set; } = new List<Event>();
}