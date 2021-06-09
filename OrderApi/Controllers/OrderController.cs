using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {


        private readonly OrderContext orderDb;
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders()//get all orders
        {
            IQueryable<Order> query = orderDb.Orders;
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrders(int id)//get order by id
        {
            var o = orderDb.Orders.Where(o => o.Id == id);
            return (Order)o;
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id, Order order)
        {
            try
            {
                orderDb.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string err = e.Message;
                return BadRequest(err);
            }
            return order;
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(o => o.Id == id);
                if (order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
