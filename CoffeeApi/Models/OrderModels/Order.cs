using System.Collections.Generic;
using CoffeeApi.Enumerations;

namespace CoffeeApi.Models.OrderModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public string OrderRecipient { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
    }
}