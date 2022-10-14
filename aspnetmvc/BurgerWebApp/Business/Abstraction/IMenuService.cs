using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;

namespace Business.Abstraction
{
    public interface IMenuService
    {
        List<MenuItemViewModel> GetAll();
        MenuItemViewModel GetById(int id);
        void Save(MenuItemViewModel model);
        void Delete(int id);
        List<SelectListItem> GetMenuItemsSelectList();
    }
}
