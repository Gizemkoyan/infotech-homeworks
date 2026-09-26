namespace week05.Models;

public class ReservationIdentity
{
    public Guid Id { get; }

    public ReservationIdentity()
    {
        Id = Guid.NewGuid();
    }
}