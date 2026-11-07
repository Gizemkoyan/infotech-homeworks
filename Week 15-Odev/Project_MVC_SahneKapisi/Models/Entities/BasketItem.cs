namespace Project_MVC_SahneKapisi.Models.Entities;

public class BasketItem
{
    public int Id { get; set; }
    public int BasketId { get; set; }
    public Basket? Basket { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }
    public int Quantity { get; set; }
}