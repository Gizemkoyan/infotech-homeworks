namespace week05.Plans;

public class VipTicketPlan : TicketPlan
{
    public VipTicketPlan()
        : base("VIP Bilet")
    {
    }

    public override decimal CalculatePrice(decimal basePrice)
    {
        if (basePrice <= 0)
            throw new ArgumentOutOfRangeException(nameof(basePrice), "Fiyat sıfırdan büyük olmalıdır.");

        return basePrice + 500;
    }
}