using ViewModels;
using DomainModels;

namespace Mappers
{
    public static class OrderItemMapper
    {
        public static OrderItemViewModel ToViewModel(this OrderItem orderItem)
        {
            return new OrderItemViewModel
            {
                Id = orderItem.Id,
                MenuItem = orderItem.MenuItem.ToViewModel(),
                Quantity = orderItem.Quantity,
            };
        }

    }
}
