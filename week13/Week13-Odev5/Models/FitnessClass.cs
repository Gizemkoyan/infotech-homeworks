namespace week13_odev5.Models;

public class FitnessClass
{
    public int Id { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public int Capacity { get; set; }
    public decimal Fee { get; set; }
    public bool IsActive { get; set; }

    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
}