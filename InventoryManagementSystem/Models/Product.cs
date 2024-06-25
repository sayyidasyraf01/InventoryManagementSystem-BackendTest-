namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductCategory { get; set; }

        // Navigation properties
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; }

        // Foreign key property
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } // Navigation property

        // Other properties and methods as needed
    }
}

