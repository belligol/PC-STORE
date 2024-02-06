using PC_STORE.DL.InMemoryDb;
using PC_STORE.Models;
using PC_STORE.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_STORE.DL.Repositories
{
    public static class OrderRepository
    {
        public static IEnumerable<Order> GetAllOrders()
        {
            return DataStore.Orders;
        }

        public static Order GetOrderById(Guid id)
        {
            return DataStore.Orders.FirstOrDefault(order => order.Id == id);
        }

        public static IEnumerable<Order> GetOrdersByProductId(int productId)
        {
            return DataStore.Orders.Where(order => order.ProductId == productId);
        }

        public static void AddOrder(Order order)
        {
            DataStore.Orders.Add(order);
        }

        public static void UpdateOrder(Order updatedOrder)
        {
            var existingOrder = DataStore.Orders.FirstOrDefault(order => order.Id == updatedOrder.Id);
            if (existingOrder != null)
            {
                existingOrder.ProductId = updatedOrder.ProductId;
                existingOrder.Quantity = updatedOrder.Quantity;
            }
            else
            {
                throw new InvalidOperationException($"Order with id {updatedOrder.Id} not found.");
            }
        }

        public static void DeleteOrder(Guid id)
        {
            var order = DataStore.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                DataStore.Orders.Remove(order);
            }
            else
            {
                throw new InvalidOperationException($"Order with id {id} not found.");
            }
        }
    }
}
