using DataAccess.Abstraction;
using DomainModels;

namespace DataAccess.Repositories
{
    public class SizeRepository : IRepository<Size>
    {
        private readonly BurgerAppDbContext _dbContext;

        public SizeRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Size> GetAll()
        {
            return _dbContext.Sizes.ToList();
        }

        public Size GetById(int id)
        {
            return _dbContext.Sizes.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Size entity)
        {
            _dbContext.Sizes.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Size entity)
        {
            var item = GetById(entity.Id);

            if(item != null)
            {
                _dbContext.Sizes.Update(item);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);

            if(item != null)
            {
                _dbContext.Sizes.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
