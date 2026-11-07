namespace week13_odev03.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }
    public int PreparationTimeMinutes { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    public int MenuCategoryId { get; set; }
    public MenuCategory MenuCategory { get; set; } = null!;
}