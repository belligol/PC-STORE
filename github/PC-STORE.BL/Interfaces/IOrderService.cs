using PC_STORE.Models;
using PC_STORE.Models.Data;
using PC_STORE.MODELS.Request;


namespace PC_STORE.BL.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(Guid id);
        Task AddOrder(AddOrderRequest orderRequest);
        Task DeleteOrder(Guid id);
    }
}

