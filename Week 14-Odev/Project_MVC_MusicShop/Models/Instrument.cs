namespace Project_MVC_MusicShop.Models
{
    public class Instrument
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int InstrumentCategoryId { get; set; }

        public InstrumentCategory? InstrumentCategory { get; set; }
    }
}