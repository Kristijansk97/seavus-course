using Microsoft.AspNetCore.Mvc;
using Business.Abstraction;
using ViewModels;

namespace BurgerWebApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IBurgerService _burgerService;
        private readonly ISizeService _SizeService;

        public MenuController(IMenuService menuService, IBurgerService burgerService, ISizeService sizeService)
        {
            _menuService = menuService;
            _burgerService = burgerService;
            _SizeService = sizeService;
        }

        public IActionResult Index()
        {
            return View(_menuService.GetAll());
        }

        public IActionResult CreateEditMenuItem(int? id)
        {
            var menuItem = id.HasValue ? _menuService.GetById(id.Value) : new MenuItemViewModel();

            ViewBag.Burgers = _burgerService.GetBurgersSelectList();
            ViewBag.Sizes =  _SizeService.GetSizesSelectList();

            return View(menuItem);
        }

        public IActionResult Save(MenuItemViewModel model)
        {
            _menuService.Save(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _menuService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
