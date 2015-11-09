using CoffeeApi.Enumerations;

namespace CoffeeApi.Models.MenuModels
{
    public class Drink
    {
        public string Name { get; set; }
        public int DrinkId { get; set; }
        public int Price { get; set; }
        public Size Size { get; set; }
    }
}