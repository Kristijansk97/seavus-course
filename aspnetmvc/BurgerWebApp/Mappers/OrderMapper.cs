using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Name = order.Name,
                PhoneNumber = order.PhoneNumber,
                Address = order.Address,
                Note = order.Note,
                Items = order.OrderItems.Select(x => x.ToViewModel()).ToList(),
                TotalPrice = order.OrderItems == null ? 0 : order.OrderItems.Sum(x => x.Quantity * x.MenuItem.Price)
            };
        }
    }
}
