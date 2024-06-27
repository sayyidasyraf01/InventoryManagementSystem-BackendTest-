using InventoryManagementSystem.Interface;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Services;
using System.Runtime.CompilerServices;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController (IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("Products")]
        public async Task<ActionResult> GetProduct() //get all product
        {
            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpGet("products/{id}")]
        public async Task<ActionResult<Product>> GetProductId (int id) //get specific product by id 
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null) {
                return NotFound();  
            }
            return Ok(product);
        }
        [HttpPost("add")]
        public async Task <ActionResult> AddProduct ( Product product)
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        [HttpPut("products/{id}")]

        public async Task <IActionResult> UpdateProductAsync (int id, [FromBody] Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            await _productService.UpdateProductAsync(product);
            return Ok();
        }

        [HttpDelete("product/{id}")]
        public async Task<IActionResult> DeleteProductAsync (int id)
        {
            await _productService.DeleteProductAsync(id);   
            return Ok();
        }
  

    }
}
