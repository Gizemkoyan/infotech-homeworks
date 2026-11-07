namespace Project_MVC_SahneKapisi.Models.Entities;

public class Basket
{
    public int Id { get; set; }
    public string AppUserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
    public ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
}