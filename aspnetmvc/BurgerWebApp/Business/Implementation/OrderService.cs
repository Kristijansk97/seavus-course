using Business.Abstraction;
using DataAccess.Abstraction;
using ViewModels;
using DomainModels;
using Mappers;

namespace Business.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> ordersRepository)
        {
            _orderRepository = ordersRepository;
        }

        public List<OrderViewModel> GetAll()
        {
            var orders = _orderRepository.GetAll().Select(x => x.ToViewModel()).ToList();

            return orders;
        }

        public OrderViewModel Details(int id)
        {
            var order = _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception("Order item does not exist");
            }

            return order.ToViewModel();
        }

        public int Save(OrderViewModel model)
        {
            if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Address) || string.IsNullOrEmpty(model.PhoneNumber.ToString()))
            {
                throw new Exception("All fields are required");
            }

            if (_orderRepository.GetAll().Any(x => x.Name == model.Name && x.Address == model.Address && x.PhoneNumber == model.PhoneNumber && x.Id == model.Id))
            {
                throw new Exception("Order already exists");
            }

            var order = new Order(model.Name, model.PhoneNumber, model.Address, model.Note, new List<OrderItem>());

            _orderRepository.Insert(order);

            return order.Id;
        }


        public void Delete(int id)
        {
            var existingOrder = _orderRepository.GetById(id);

            if (existingOrder == null)
            {
                throw new Exception($"Order with id {id} does not exist");
            }

            _orderRepository.DeleteById(existingOrder.Id);
        }
    }
}
