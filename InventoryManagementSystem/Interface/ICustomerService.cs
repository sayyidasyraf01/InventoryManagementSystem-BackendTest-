using InventoryManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    public  interface ICustomerService
    {
        Task<ICollection<Customer>> GetAllCustomersAsync(); //get all cust
        Task<Customer> GetCustomerByIdAsync(int id); //get by id
        Task AddCustomerAsync (Customer customer); //add cust
        Task UpdateCustomerAsync (Customer customer); //edit cust
        Task DeleteCustomerAsync(int id); //delete cust
    }
}
