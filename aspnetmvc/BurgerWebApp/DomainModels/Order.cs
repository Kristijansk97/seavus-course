namespace DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {

        }

        public Order(string name, int phoneNumber, string address, string note, List<OrderItem> items)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Note = note;
            OrderItems = items;
        }
    }
}
