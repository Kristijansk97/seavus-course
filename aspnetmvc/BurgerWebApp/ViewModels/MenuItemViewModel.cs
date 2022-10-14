using DomainModels;
using System.Globalization;

namespace ViewModels
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public BurgerViewModel Burger { get; set; }
        public int BurgerId { get; set; }
        public SizeViewModel Size { get; set; }
        public int SizeId { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Burger.Name} ({Size.Name}) [{Price.ToString("C", CultureInfo.CreateSpecificCulture("mk-MK"))}]";
        }
    }
}
