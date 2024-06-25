using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerController>>> GetCustomer()
        {
            return Ok(await _customerService.GetAllCustomersAsync());
        }
    }
}
