using DomainModels;
using ViewModels;
using Mappers;
using DataAccess.Abstraction;
using Business.Abstraction;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Business.Implementation
{
    public class SizeService : ISizeService
    {
        private readonly IRepository<Size> _sizeRepository;
        private readonly IRepository<MenuItem> _menuItemRepository;

        public SizeService(IRepository<Size> sizeRepository, IRepository<MenuItem> menuItemRepository)
        {
            _sizeRepository = sizeRepository;
            _menuItemRepository = menuItemRepository;
        }

        public List<SizeViewModel> GetAll()
        {
            var sizes = _sizeRepository.GetAll().Select(x => x.ToViewModel()).OrderBy(x => x.Name).ThenBy(x => x.Description).ToList();

            return sizes;
        }

        public SizeViewModel Details(int id)
        {
            var size = _sizeRepository.GetById(id);

            if(size == null)
            {
                throw new Exception("Size does not exist");
            }

            return size.ToViewModel();
        }

        public void Save(SizeViewModel model)
        {
            if(string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Description))
            {
                throw new Exception("All fields are required");
            }

            if(_sizeRepository.GetAll().Any(x => (x.Name == model.Name || x.Description == model.Description) && x.Id != model.Id))
            {
                throw new Exception("Size already exists");
            }

            if(model.Id == 0)
            {
                var newSize = new Size(model.Name, model.Description);

                _sizeRepository.Insert(newSize);

                return;
            }

            var existingSize = _sizeRepository.GetById(model.Id);

            if(existingSize == null)
            {
                throw new Exception("Size does not exist");
            }

            existingSize.Name = model.Name;
            existingSize.Description = model.Description;

            _sizeRepository.Update(existingSize);
        }

        public void Delete(int id)
        {
            var size = _sizeRepository.GetById(id);

            if(size == null)
            {
                throw new Exception("Size does not exist");
            }

            var menuItems = _menuItemRepository.GetAll().Where(x => x.Size.Id == id).ToList();

            foreach(var menuItem in menuItems)
            {
                _menuItemRepository.DeleteById(menuItem.Id);
            }

            _sizeRepository.DeleteById(size.Id);
        }

        public List<SelectListItem> GetSizesSelectList()
        {
            return _sizeRepository.GetAll().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }
    }
}
