using DataAccess.Abstraction;
using DomainModels;

namespace DataAccess.Repositories
{
    public class OrderItemRepository : IRepository<OrderItem>
    {
        private readonly BurgerAppDbContext _dbContext;

        public OrderItemRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<OrderItem> GetAll()
        {
            return _dbContext.OrderItems.ToList();
        }

        public OrderItem GetById(int id)
        {
            return _dbContext.OrderItems.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(OrderItem entity)
        {
            _dbContext.OrderItems.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(OrderItem entity)
        {
            var item = GetById(entity.Id);

            if (item != null)
            {
                _dbContext.OrderItems.Update(item);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);

            if (item != null)
            {
                _dbContext.OrderItems.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
