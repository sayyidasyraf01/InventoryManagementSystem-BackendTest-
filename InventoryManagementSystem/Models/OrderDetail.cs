namespace InventoryManagementSystem.Models
{
    public class OrderDetail
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DetailQuantity { get; set; }
        public decimal DetailUnitPrice { get; set; }
    }
}
