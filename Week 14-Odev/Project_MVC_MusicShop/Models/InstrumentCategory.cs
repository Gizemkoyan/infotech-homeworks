namespace Project_MVC_MusicShop.Models
{
    public class InstrumentCategory
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Instrument> Instruments { get; set; } = new();
    }
}