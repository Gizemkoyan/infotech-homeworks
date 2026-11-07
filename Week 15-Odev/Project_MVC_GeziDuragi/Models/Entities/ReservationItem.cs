namespace Project_MVC_GeziDuragi.Models.Entities;

public class ReservationItem
{
    public int Id { get; set; }
    public int ReservationId { get; set; }
    public Reservation? Reservation { get; set; }
    public int TourId { get; set; }
    public Tour? Tour { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}