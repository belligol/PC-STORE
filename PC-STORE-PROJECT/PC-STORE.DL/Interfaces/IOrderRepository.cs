using PC_STORE.Models.Data;

namespace PC_STORE.DL.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(int id);
        Task AddOrder(Order order);
        Task DeleteOrder(int id);
    }
}
