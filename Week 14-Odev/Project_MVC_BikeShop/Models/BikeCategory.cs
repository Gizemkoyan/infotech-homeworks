
namespace Project_MVC_BikeShop.Models
{
    public class BikeCategory
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Bike> Bikes { get; set; } = new();
    }
}
