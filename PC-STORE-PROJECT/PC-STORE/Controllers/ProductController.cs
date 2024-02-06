using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PC_STORE.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using PC_STORE.BL.Interfaces;
using PC_STORE.MODELS.Data;
using PC_STORE.MODELS.Request;

namespace PC_STORE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Product>))]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddProductRequest productRequest)
        {
            await _productService.AddProduct(productRequest);
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            await _productService.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int productId)
        {
            await _productService.DeleteProduct(productId);
            return Ok();
        }
    }
}
