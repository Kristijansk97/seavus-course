using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;

namespace Business.Abstraction
{
    public interface IBurgerService
    {
        List<BurgerViewModel> GetAll();
        BurgerViewModel GetById(int id);
        void Save(BurgerViewModel model);
        void Delete(int id);
        List<SelectListItem> GetBurgersSelectList();
    }
}
