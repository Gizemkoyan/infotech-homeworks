namespace week05.Plans;

public abstract class TicketPlan
{
    public string PlanName { get; set; }

    protected TicketPlan(string planName)
    {
        PlanName = planName;
    }

    public void PrintPlanName()
    {
        Console.WriteLine($"Bilet Planı: {PlanName}");
    }

    public abstract decimal CalculatePrice(decimal basePrice);
}