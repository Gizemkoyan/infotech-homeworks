
namespace Project_MVC_BikeShop.Models
{
    public class Bike
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string FrameSize { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int BikeCategoryId { get; set; }

        public BikeCategory? BikeCategory { get; set; }
    }
}
