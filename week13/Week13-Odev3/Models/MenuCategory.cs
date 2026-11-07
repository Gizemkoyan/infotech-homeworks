namespace week13_odev03.Models;

public class MenuCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }

    public List<MenuItem> MenuItems { get; set; } = new();
}