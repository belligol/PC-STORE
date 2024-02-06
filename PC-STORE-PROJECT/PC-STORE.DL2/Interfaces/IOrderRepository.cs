using PC_STORE.Models.Data;

namespace PC_STORE.DL2.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(Guid id);
        Task AddOrder(Order order);
        Task DeleteOrder(Guid id);
    }
}