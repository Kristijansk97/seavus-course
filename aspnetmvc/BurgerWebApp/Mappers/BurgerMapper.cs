using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class BurgerMapper
    {
        public static BurgerViewModel ToViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Description = burger.Description,
                ImageUrl = burger.ImageUrl
            };
        }
    }
}
