using Microsoft.AspNetCore.Mvc;
using Business.Abstraction;
using ViewModels;

namespace BurgerWebApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;

        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }

        public IActionResult Index()
        {
            return View(_burgerService.GetAll());
        }

        public IActionResult Details(int id)
        {
            var burger = _burgerService.GetById(id);
            return View(burger);
        }

        public IActionResult CreateEditBurger(int? id)
        {
            var model = id.HasValue ? _burgerService.GetById(id.Value) : new BurgerViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Save(BurgerViewModel model)
        {
            _burgerService.Save(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _burgerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
