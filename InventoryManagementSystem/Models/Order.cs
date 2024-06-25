namespace InventoryManagementSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; } //Foreign Key
        public Customer Customer { get; set; } //Navigation property *one to many *Each Order belongs to exactly one Customer (Customer property in Order).
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    }
}
