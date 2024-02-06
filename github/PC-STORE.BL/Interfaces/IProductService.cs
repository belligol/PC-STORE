using PC_STORE.MODELS.Data;
using PC_STORE.MODELS.Request;

namespace PC_STORE.BL.Interfaces
{

    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task AddProduct(AddProductRequest product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
