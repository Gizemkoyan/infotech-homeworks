namespace week05.Interfaces;

public interface IPaymentService
{
    bool ProcessPayment(decimal amount);
}