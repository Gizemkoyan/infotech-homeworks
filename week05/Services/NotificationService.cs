using week05.Interfaces;

namespace week05.Services;

public class NotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Bildirim: {message}");
    }
}