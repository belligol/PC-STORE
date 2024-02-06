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
using PC_STORE.Models.Data;

namespace PC_STORE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Order>))]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAll();
            return Ok(orders);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Order))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var order = await _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddOrderRequest orderRequest)
        {
            await _orderService.AddOrder(orderRequest);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}

