using Project_MVC_SahneKapisi.Models.ComplexTypes;
namespace Project_MVC_SahneKapisi.Models.Entities;

public class TicketOrder
{
    public int Id { get; set; }
    public string AppUserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
    public DateTime OrderDate { get; set; }
    public TicketOrderStatus TicketOrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<TicketOrderItem> TicketOrderItems { get; set; } = new List<TicketOrderItem>();
}