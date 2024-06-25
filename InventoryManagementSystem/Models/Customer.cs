namespace InventoryManagementSystem.Models
{
    public class Customer
    {
        public int CustomerId {  get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public ICollection<Order> Orders { get; set; } //one to many *each customer can have zero or may order *Each Customer can have multiple Order objects associated with them (ICollection<Order> in Customer).
    }
}
