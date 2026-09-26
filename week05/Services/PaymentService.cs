using week05.Interfaces;

namespace week05.Services;

public class PaymentService : IPaymentService
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount <= 0)
            return false;

        Console.WriteLine($"Ödeme alındı: {amount:C}");
        return true;
    }
}