using week05.Interfaces;

namespace week05.Services;

public class TicketOrderService
{
    private readonly IPaymentService _paymentService;
    private readonly INotificationService _notificationService;

    public TicketOrderService(
        IPaymentService paymentService,
        INotificationService notificationService)
    {
        _paymentService = paymentService;
        _notificationService = notificationService;
    }

    public void CompleteOrder(decimal amount)
    {
        bool paymentSuccessful = _paymentService.ProcessPayment(amount);

        if (paymentSuccessful)
        {
            _notificationService.SendNotification(
                "Bilet siparişiniz başarıyla tamamlandı.");
        }
    }
}