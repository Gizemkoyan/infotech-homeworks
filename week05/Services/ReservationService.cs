using week05.Interfaces;
using week05.Models;

namespace week05.Services;

public class ReservationService
{
    private decimal _totalAmount;

    public ReservationIdentity Identity { get; }

    public ReservationService(decimal startingAmount)
    {
        if (startingAmount < 0)
            throw new ArgumentOutOfRangeException(
                nameof(startingAmount),
                "Başlangıç tutarı negatif olamaz.");

        _totalAmount = startingAmount;
        Identity = new ReservationIdentity();
    }

    public void AddTicket(decimal ticketPrice, int quantity)
    {
        if (ticketPrice <= 0 || quantity <= 0)
            return;

        _totalAmount += ticketPrice * quantity;
    }

    public void ApplyDiscount(IDiscountStrategy discountStrategy)
    {
        _totalAmount = discountStrategy.ApplyDiscount(_totalAmount);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Rezervasyon No: {Identity.Id}");
        Console.WriteLine($"Rezervasyon toplamı: {_totalAmount:C}");
    }
}