using System;
using System.Collections.Generic;
using CoffeeApi.Models.OrderModels;

namespace CoffeeApi.DataAccess
{
    public interface IOrdersRepository
    {
        List<Order> GetActiveOrders();
        Order AddOrder(Order newOrder);
        Order GetOrder(int orderId);
        Order AlterOrder(int orderId, Order orderToChange);
        bool DeleteOrder(int orderId);
    }

    public class OrdersRepository : IOrdersRepository
    {
        public List<Order> GetActiveOrders()
        {
            throw new NotImplementedException();
        }

        public Order AddOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order AlterOrder(int orderId, Order orderToChange)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}