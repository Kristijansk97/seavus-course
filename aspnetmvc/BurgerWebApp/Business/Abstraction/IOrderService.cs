using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;

namespace Business.Abstraction
{
    public interface IOrderService
    {
        List<OrderViewModel> GetAll();
        OrderViewModel Details(int id);
        int Save(OrderViewModel model);
        void Delete(int id);
    }
}
