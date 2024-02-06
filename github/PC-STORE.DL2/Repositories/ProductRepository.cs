using PC_STORE.DL2.InMemoryDb;
using PC_STORE.DL2.Interfaces;
using PC_STORE.MODELS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_STORE.DL2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(DataStore.Products);
        }

        public async Task<Product> GetById(int id)
        {
            return await Task.FromResult(DataStore.Products.FirstOrDefault(p => p.Id == id));
        }

        public async Task AddProduct(Product product)
        {
            await Task.Run(() => DataStore.Products.Add(product));
        }

        public async Task UpdateProduct(Product product)
        {
            var existingProduct = DataStore.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteProduct(int id)
        {
            var product = DataStore.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                DataStore.Products.Remove(product);
            }
            await Task.CompletedTask;
        }
    }
}
