using week05.Interfaces;

namespace week05.Access;

public class AgeAccessValidator : IAccessValidator
{
    public bool CanEnter(int value)
    {
        return value >= 18;
    }
}