using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class InventoryTransaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TransactionQuantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
