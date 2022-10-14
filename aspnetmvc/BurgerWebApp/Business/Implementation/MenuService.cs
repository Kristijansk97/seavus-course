using Business.Abstraction;
using DataAccess.Abstraction;
using DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;
using Mappers;

namespace Business.Implementation
{
    public class MenuService : IMenuService
    {
        private readonly IRepository<MenuItem> _menuItemRepository;
        private readonly IRepository<Size> _sizeRepository;
        private readonly IRepository<Burger> _burgerRepository;

        public MenuService(IRepository<MenuItem> menuItemRepository, IRepository<Size> sizeRepository, IRepository<Burger> burgerRepository)
        {
            _menuItemRepository = menuItemRepository;
            _sizeRepository = sizeRepository;
            _burgerRepository = burgerRepository;
        }

        public List<MenuItemViewModel> GetAll()
        {
            var menu = _menuItemRepository.GetAll().Select(x => x.ToViewModel()).OrderBy(x => x.Burger.Name).ThenBy(x => x.Size.Description).ToList();

            return menu;
        }

        public MenuItemViewModel GetById(int id)
        {
            var item = _menuItemRepository.GetById(id);

            if(item == null)
            {
                throw new Exception("Menu item does not exist");
            }

            var menuItem = new MenuItemViewModel
            {
                Id = item.Id,
                Price = item.Price,
                BurgerId = item.BurgerId,
                SizeId = item.SizeId
            };

            return menuItem;
        }
        public void Save(MenuItemViewModel model)
        {
            if(model.BurgerId == 0 || model.SizeId == 0 || model.Price == 0)
            {
                throw new Exception("All fields are required");
            }

            var selectedSize = _sizeRepository.GetById(model.SizeId);

            if(selectedSize == null)
            {
                throw new Exception("Size does not exist");
            }

            var selectedBurger = _burgerRepository.GetById(model.BurgerId);

            if (selectedBurger == null)
            {
                throw new Exception("Burger does not exist");
            }

            if(model.Price <= 0)
            {
                throw new Exception("Invalid price");
            }

            if(_menuItemRepository.GetAll().Any(x => x.BurgerId == model.BurgerId && x.SizeId == model.SizeId && x.Id != model.Id))
            {
                throw new Exception("Menu item already exists");
            }

            if(model.Id == 0)
            {
                var menuItem = new MenuItem(model.BurgerId, model.SizeId, model.Price);

                _menuItemRepository.Insert(menuItem);

                return;
            }

            var existingMenuItem = _menuItemRepository.GetById(model.Id);

            if (existingMenuItem == null)
            {
                throw new Exception($"Menu item does not exist.");
            }

            existingMenuItem.Burger = selectedBurger;
            existingMenuItem.Size = selectedSize;
            existingMenuItem.Price = model.Price;

            _menuItemRepository.Update(existingMenuItem);
        }
        public void Delete(int id)
        {
            var item = _menuItemRepository.GetById(id);

            if(item == null)
            {
                throw new Exception("Menu item does not exist");
            }

            _menuItemRepository.DeleteById(item.Id);
        }

        public List<SelectListItem> GetMenuItemsSelectList()
        {
            return _menuItemRepository.GetAll().Select(x => new SelectListItem(x.ToString(), x.Id.ToString())).ToList();
        }
    }
}
