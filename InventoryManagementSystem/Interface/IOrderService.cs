using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Interface
{
    public interface IOrderService 
    {
        Task<ICollection<Order>> GetAllOrderAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync (Order order);    
        Task DeleteOrderAsync (int id);
    }
}
