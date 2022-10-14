using Microsoft.EntityFrameworkCore;
using DataAccess.Abstraction;
using DomainModels;

namespace DataAccess.Repositories
{
    public class MenuItemRepository : IRepository<MenuItem>
    {
        private readonly BurgerAppDbContext _dbContext;

        public MenuItemRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<MenuItem> GetAll()
        {
            return _dbContext.MenuItems.Include(x => x.Burger).Include(x => x.Size).ToList();
        }

        public MenuItem GetById(int id)
        {
            return _dbContext.MenuItems.Include(x => x.Burger).Include(x => x.Size).FirstOrDefault(x => x.Id == id);
        }

        public void Insert(MenuItem entity)
        {
            _dbContext.MenuItems.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(MenuItem entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                _dbContext.MenuItems.Update(entity);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);

            if (item != null)
            {
                _dbContext.MenuItems.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
