using System.Globalization;

namespace DomainModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int BurgerId { get; set; }
        public Burger Burger { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int Price { get; set; }

        public MenuItem()
        {

        }

        public MenuItem(int burgerId, int sizeId, int price)
        {
            BurgerId = burgerId;
            SizeId = sizeId;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Burger.Name} ({Size.Name}) [{Price.ToString("C", CultureInfo.CreateSpecificCulture("mk-MK"))}]";
        }
    }
}
