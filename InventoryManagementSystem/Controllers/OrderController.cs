using InventoryManagementSystem.Interface;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("orders")]
        public async Task<ActionResult> GetOrder() //get all order
        {
            return Ok(await _orderService.GetAllOrderAsync());
        }

        [HttpGet("orders/{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id) //get order with specific orderid
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost("add")] 
        public async Task<ActionResult> AddOrder(Order order)
        {
            await _orderService.AddOrderAsync(order);
            return Ok();
        }

        [HttpPut("orders/{id}")]
        public async Task<ActionResult> UpdateOrder (int id,Order order)
        {
            if (id != order.CustomerId)
            {
                return BadRequest();
            }
            await _orderService.UpdateOrderAsync(order);
            return Ok();
        }

        [HttpDelete("orders/{id}")]
        public async Task<ActionResult> DeleteOrder (int id)
        {
            await _orderService.DeleteOrderAsync(id);
            return Ok();
        }
    }
}
