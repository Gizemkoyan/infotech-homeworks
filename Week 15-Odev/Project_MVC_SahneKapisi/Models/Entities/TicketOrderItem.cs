namespace Project_MVC_SahneKapisi.Models.Entities;

public class TicketOrderItem
{
    public int Id { get; set; }
    public int TicketOrderId { get; set; }
    public TicketOrder? TicketOrder { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}