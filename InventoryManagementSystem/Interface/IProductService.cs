using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Interface
{
    public interface IProductService
    {
        Task<ICollection<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync (Product product); 
        Task UpdateProductAsync (Product product);  
        Task DeleteProductAsync (int id);

    }
}
