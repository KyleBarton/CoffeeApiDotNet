using System.Collections.Generic;
using CoffeeApi.Models.MenuModels;

namespace CoffeeApi.Models.OrderModels
{
    public class OrderItem
    {
        public Drink ItemDrink { get; set; }
        public List<Extra> ItemExtras { get; set; } 
    }
}