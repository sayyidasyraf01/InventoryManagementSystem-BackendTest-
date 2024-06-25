namespace InventoryManagementSystem.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }

        // Navigation property to represent the relationship
        public ICollection<Product> Products { get; set; }
    }
}
