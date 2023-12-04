using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClassLibraryMVC.Data;
using WarehouseClassLibraryMVC.Entities;

namespace WarehouseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly WarehouseContext _context;

        public OrderItemsController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        {
          if (_context.OrderItems == null)
          {
              return NotFound();
          }

          List<OrderItem> orderList = new List<OrderItem>();

            var orderItems = await _context.OrderItems.ToListAsync();

            Product? product = new();

            foreach(var orderItem in orderItems)
            {
                product = await _context.Products.FindAsync(orderItem.ProductId);

                var orderItemView = new OrderItem
                {
                    OrderId = orderItem.OrderId,
                    Quantity = orderItem.Quantity,
                    ProductId = orderItem.ProductId,
                    Price = orderItem.Price,
                    Product = product
                };

                orderList.Add(orderItemView);

            }

            return orderList;
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<OrderItem>>> GetOrderItem(int id)
        {
          if (_context.OrderItems == null)
          {
              return NotFound();
          }

            List<OrderItem> orderList = new List<OrderItem>();

            var orderItems = await _context.OrderItems.Where(item => item.OrderId == id).ToListAsync();

            if (orderItems == null)
            {
                return NotFound();
            }

            Product? product = new();

            foreach (var item in orderItems)
            {
                product = await _context.Products.FindAsync(item.ProductId);

                var itemView = new OrderItem
                {
                    OrderId = item.OrderId,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                    Price = item.Price,
                    Product = product
                };

                orderList.Add(itemView);

            }

            return orderList;
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderItem)
        {
            if (id != orderItem.OrderItemId)
            {
                return BadRequest();
            }

            _context.Entry(orderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderItem)
        {
          if (_context.OrderItems == null)
          {
              return Problem("Entity set 'WarehouseContext.OrderItems'  is null.");
          }
            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderItem", new { id = orderItem.OrderItemId }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            if (_context.OrderItems == null)
            {
                return NotFound();
            }
            var orderItem = await _context.OrderItems.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderItemExists(int id)
        {
            return (_context.OrderItems?.Any(e => e.OrderItemId == id)).GetValueOrDefault();
        }
    }
}
