namespace Project_MVC_GeziDuragi.Models.Entities;

public class Cart
{
    public int Id { get; set; }
    public string AppUserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}