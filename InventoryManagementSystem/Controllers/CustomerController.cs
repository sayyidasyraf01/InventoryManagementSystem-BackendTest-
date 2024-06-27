using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        [HttpGet("customers")]
        public async Task<ActionResult> GetCustomer()
        {
            return Ok(await _customerService.GetAllCustomersAsync());
        }

        [HttpGet("customers/{id}")]
        public async Task<ActionResult<Customer>> GetCustomerId(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddCustomerAsync(Customer customer)
        {
            await _customerService.AddCustomerAsync(customer);
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId },customer);
        }

        [HttpPut("customers/{id}")]
        public async Task<IActionResult> UpdateCustomerAsync(int id, [FromBody] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }
            await _customerService.UpdateCustomerAsync(customer);
            return Ok();
        }

        [HttpDelete("customers/{id}")]
        public async Task<IActionResult>DeleteCustomerAsync(int id)
        {
            await _customerService.DeleteCustomerAsync(id);
            return Ok();
        }









    }

}
