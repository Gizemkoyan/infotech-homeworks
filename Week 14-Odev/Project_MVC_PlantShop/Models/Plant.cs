namespace Project_MVC_PlantShop.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public int PlantCategoryId { get; set; }
        public PlantCategory? plantCategory { get; set;}

    }
}