using Microsoft.AspNetCore.Mvc;
using ViewModels;
using Business.Abstraction;

namespace BurgerWebApp.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly IOrderItemService _orderItemService;
        private readonly IMenuService _menuService;

        public OrderItemController(IOrderItemService orderItemService, IMenuService menuService)
        {
            _orderItemService = orderItemService;
            _menuService = menuService;
        }

        public IActionResult CreateOrderItem(int id)
        {
            ViewBag.MenuItems = _menuService.GetMenuItemsSelectList();

            var orderItem = new OrderItemViewModel()
            {
                OrderId = id
            };

            return View(orderItem);
        }

        [HttpPost]
        public IActionResult Save(OrderItemViewModel model)
        {
             _orderItemService.Save(model);
            return RedirectToAction("Details", "Order", new { id = model.OrderId });
        }

        public IActionResult Delete(int id)
        {
            var orderId = _orderItemService.Delete(id);

            return RedirectToAction("Details", "Order", new { id = orderId });
        }
    }
}
