using System.Collections.Generic;

namespace CoffeeApi.Models.MenuModels
{
    public class Menu
    {
        public List<Drink> Drinks { get; set; }
        public List<Extra> Extras { get; set; } 
    }
}