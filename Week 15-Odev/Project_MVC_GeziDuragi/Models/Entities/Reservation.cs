using Project_MVC_GeziDuragi.Models.ComplexTypes;

namespace Project_MVC_GeziDuragi.Models.Entities;

public class Reservation
{
    public int Id { get; set; }
    public string AppUserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
    public DateTime ReservationDate { get; set; }
    public ReservationStatus ReservationStatus { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<ReservationItem> ReservationItems { get; set; } = new List<ReservationItem>();
}