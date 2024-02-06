using PC_STORE.Models.Data;
using PC_STORE.MODELS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_STORE.DL2.InMemoryDb
{
    public static class DataStore
    {
        public static List<Product> Products
            = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 999,
                    Description = "Powerful laptop for gaming and work"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Mouse",
                    Price = 25,
                    Description = "Wireless mouse with ergonomic design"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Keyboard",
                    Price = 50,
                    Description = "Mechanical keyboard for typing enthusiasts"
                }
            };

        public static List<Order> Orders
           = new List<Order>()
           {
                new Order()
                {
                    Id = Guid.NewGuid(),
                    ProductId = 1,
                    Quantity = 2
                },
                new Order()
                {
                    Id = Guid.NewGuid(),
                    ProductId = 2,
                    Quantity = 5
                },
                new Order()
                {
                    Id = Guid.NewGuid(),
                    ProductId = 1,
                    Quantity = 1
                },
                new Order()
                {
                    Id = Guid.NewGuid(),
                    ProductId = 3,
                    Quantity = 3
                }
           };
    }
}
