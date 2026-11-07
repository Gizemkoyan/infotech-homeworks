namespace week13_odev5.Models;

public class Trainer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public int ExperienceYears { get; set; }
    public string PhotoUrl { get; set; } = string.Empty;

    public List<FitnessClass> FitnessClasses { get; set; } = new();
}