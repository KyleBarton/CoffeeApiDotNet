using System;
using System.Collections.Generic;
using System.Web.Http;
using CoffeeApi.DataAccess;
using CoffeeApi.Models.OrderModels;

namespace CoffeeApi.ApiControllers
{
    public interface IOrdersController
    {
        //Interacts with the Orders queue
        [HttpGet]
        List<Order> GetAllOrders();

        [HttpPost]
        Order Submit(Order newOrder);

        //interacts with single orders on the orders queue
        [HttpGet]
        Order GetOrder(int orderId);

        [HttpPut]
        Order ChangeOrder(int orderId, Order orderToChange);

        [HttpDelete]
        bool DeleteOrder(int orderId);
    }

    public class OrdersController : ApiController, IOrdersController
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController() : this(new OrdersRepository())
        {
            
        }

        public OrdersController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        [HttpGet]
        public List<Order> GetAllOrders()
        {
            try
            {
                return _ordersRepository.GetActiveOrders();
            }
            catch (Exception ex)
            {
                //todo: log, handle gracefully
                throw;
            }
        }

        [HttpPost]
        public Order Submit(Order newOrder)
        {
            try
            {
                return _ordersRepository.AddOrder(newOrder);
            }
            catch (Exception ex)
            {
                //todo: log, handle gracefully
                throw;
            }
        }

        [HttpGet]
        public Order GetOrder(int orderId)
        {
            try
            {
                return _ordersRepository.GetOrder(orderId);
            }
            catch (Exception ex)
            {
                //todo: log, handle gracefully
                throw;
            }
        }

        [HttpPut]
        public Order ChangeOrder(int orderId, Order orderToChange)
        {
            try
            {
                return _ordersRepository.AlterOrder(orderId, orderToChange);
            }
            catch (Exception ex)
            {
                //todo: log, handle gracefully
                throw;
            }
        }

        [HttpDelete]
        public bool DeleteOrder(int orderId)
        {
            try
            {
                return _ordersRepository.DeleteOrder(orderId);
            }
            catch (Exception ex)
            {
                //todo: log, handle gracefully
                throw;
            }
        }
    }
}