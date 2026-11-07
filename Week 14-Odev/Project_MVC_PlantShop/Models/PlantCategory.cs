using System.Security.Cryptography.X509Certificates;

namespace Project_MVC_PlantShop.Models
{
    public class PlantCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 
        public List<Plant> Plants {get; set; } 
    }
}