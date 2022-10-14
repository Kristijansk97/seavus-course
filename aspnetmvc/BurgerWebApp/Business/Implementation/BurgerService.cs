using Business.Abstraction;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;
using DomainModels;
using DataAccess.Abstraction;
using Mappers;

namespace Business.Implementation
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> _burgerRepository;
        private readonly IRepository<MenuItem> _menuItemRepository;

        public BurgerService(IRepository<Burger> burgerRepository, IRepository<MenuItem> menuItemRepository)
        {
            _burgerRepository = burgerRepository;
            _menuItemRepository = menuItemRepository;
        }

        public List<BurgerViewModel> GetAll()
        {
            var burgers = _burgerRepository.GetAll().Select(x => x.ToViewModel()).ToList();

            return burgers;
        }

        public BurgerViewModel GetById(int id)
        {
            var burger = _burgerRepository.GetById(id);

            if(burger == null)
            {
                throw new Exception("Burger does not exist");
            }

            return burger.ToViewModel();
        }

        public void Save(BurgerViewModel model)
        {
            if(string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Description) || string.IsNullOrEmpty(model.ImageUrl))
            {
                throw new Exception("All fields are required");
            }

            if(_burgerRepository.GetAll().Any(x => x.Name == model.Name && x.Description == model.Description && x.ImageUrl == model.ImageUrl && x.Id == model.Id))
            {
                throw new Exception("Burger already exists");
            }

            if(model.Id == 0)
            {
                var newBurger = new Burger(model.Name, model.Description, model.ImageUrl);

                _burgerRepository.Insert(newBurger);

                return;
            }

            var existingBurger = _burgerRepository.GetById(model.Id);

            if(existingBurger == null)
            {
                throw new Exception("Burger does not exist");
            }

            existingBurger.Name = model.Name;
            existingBurger.Description = model.Description;
            existingBurger.ImageUrl = model.ImageUrl;

            _burgerRepository.Update(existingBurger);
        }

        public void Delete(int id)
        {
            var existingBurger = _burgerRepository.GetById(id);

            if(existingBurger == null)
            {
                throw new Exception("Burger does not exist");
            }

            var menuItems = _menuItemRepository.GetAll().Where(x => x.BurgerId == id);

            foreach(var menuItem in menuItems)
            {
                _menuItemRepository.DeleteById(menuItem.Id);
            }

            _burgerRepository.DeleteById(existingBurger.Id);
        }

        public List<SelectListItem> GetBurgersSelectList()
        {
            return _burgerRepository.GetAll().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }
    }
}
