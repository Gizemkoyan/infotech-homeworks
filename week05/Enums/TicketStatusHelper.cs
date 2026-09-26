namespace week05.Enums;

public static class TicketStatusHelper
{
    public static string ToTurkish(TicketStatus status)
    {
        return status switch
        {
            TicketStatus.Reserved => "Rezerve Edildi",
            TicketStatus.Paid => "Ödendi",
            TicketStatus.Cancelled => "İptal Edildi",
            _ => "Bilinmeyen Durum"
        };
    }
}