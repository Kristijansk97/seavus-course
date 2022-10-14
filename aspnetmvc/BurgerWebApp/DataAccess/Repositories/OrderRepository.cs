using DataAccess.Abstraction;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BurgerAppDbContext _dbContext;

        public OrderRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.MenuItem)
                .ThenInclude(x => x.Burger)
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.MenuItem)
                .ThenInclude(x => x.Size)
                .ToList();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.MenuItem)
                .ThenInclude(x => x.Burger)
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.MenuItem)
                .ThenInclude(x => x.Size)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            _dbContext.Orders.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Order entity)
        {
            var item = GetById(entity.Id);

            if(item != null)
            {
                _dbContext.Orders.Update(item);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);

            if(item != null)
            {
                _dbContext.Orders.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
