using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class MenuItemMapper
    {
        public static MenuItemViewModel ToViewModel(this MenuItem menuItem)
        {
            return new MenuItemViewModel
            {
                Id = menuItem.Id,
                Burger = menuItem.Burger.ToViewModel(),
                Size = menuItem.Size.ToViewModel(),
                Price = menuItem.Price
            };
        }
    }
}
