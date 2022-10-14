using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;

namespace Business.Abstraction
{
    public interface ISizeService
    {
        List<SizeViewModel> GetAll();
        SizeViewModel Details(int id);
        void Save(SizeViewModel model);
        void Delete(int id);
        List<SelectListItem> GetSizesSelectList();
    }
}
