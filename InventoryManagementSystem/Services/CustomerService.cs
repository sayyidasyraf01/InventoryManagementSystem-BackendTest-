using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Customer>>GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        //public async task<customer> getcustomerbyidasync(int id)
        //{
        //    return await _context.customers.findasync(id);
        //}
    }
}
