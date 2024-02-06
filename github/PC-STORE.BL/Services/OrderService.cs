
using AutoMapper;
using PC_STORE.BL.Interfaces;
using PC_STORE.Models;
using PC_STORE.MODELS.Request;
using PC_STORE.Models.Data;
using PC_STORE.DL2.Interfaces;

namespace PC_STORE.BL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<Order> GetById(Guid id)
        {
            return await _orderRepository.GetById(id);
        }

        public async Task AddOrder(AddOrderRequest orderRequest)
        {
            var order = _mapper.Map<Order>(orderRequest);

            await _orderRepository.AddOrder(order);
        }

        public async Task DeleteOrder(Guid id)
        {
            await _orderRepository.DeleteOrder(id);
        }
    }
}

