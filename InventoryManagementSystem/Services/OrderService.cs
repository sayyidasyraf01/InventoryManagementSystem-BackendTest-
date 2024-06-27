using InventoryManagementSystem.Data;
using InventoryManagementSystem.Interface;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Order>> GetAllOrderAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.FindAsync();
        }

        public async Task AddOrderAsync (Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync (Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteOrderAsync (int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if  (order !=null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();  
            }
        }
    }


}
