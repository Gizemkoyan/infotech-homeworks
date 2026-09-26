namespace week05.Plans;

public class StandardTicketPlan : TicketPlan
{
    public StandardTicketPlan()
        : base("Standart Bilet")
    {
    }

    public override decimal CalculatePrice(decimal basePrice)
    {
        if (basePrice <= 0)
            throw new ArgumentOutOfRangeException(nameof(basePrice), "Fiyat sıfırdan büyük olmalıdır.");

        return basePrice;
    }
}