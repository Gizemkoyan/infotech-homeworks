namespace Project_MVC_GeziDuragi.Models.Entities;

public class CartItem
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public Cart? Cart { get; set; }
    public int TourId { get; set; }
    public Tour? Tour { get; set; }
    public int Quantity { get; set; }
}