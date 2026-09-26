using week05.Interfaces;

namespace week05.Access;

public class TicketCodeAccessValidator : IAccessValidator
{
    public bool CanEnter(int value)
    {
        return value >= 1000 && value <= 9999;
    }
}