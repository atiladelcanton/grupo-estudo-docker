using System.Collections.Generic;
using apiorder.Data;
using apiorder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace apiorder.Controllers
{

    [Controller]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private DataContext context;

        public OrderController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("/")]
        public string home()
        {
            return "hello word";
        }

        [HttpGet("api")]
        public async Task<ActionResult> List()
        {
            return Ok(await context.order.Include(x=>x.itens).Include(y=>y.customer).ToListAsync());
        }

        [HttpPost("api")]
        public async Task<ActionResult> Add([FromBody] Order o)
        {
            try
            {
                Customer customer = await this.CustomerName(o.customer.name);
                
                if(customer == null){
                    context.customer.Add(o.customer);
                    await context.SaveChangesAsync();
                    customer = await this.CustomerName(o.customer.name);
                }

                o.customer = customer;
                context.order.Add(o);
                await context.SaveChangesAsync();
                return Created("Create Order",o);
            }
            catch(Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpDelete("api/{id}")]
        public async Task<ActionResult> Del(int id)
        {
            Order o = OrderId(id);
            if(o==null) {
                return NotFound("Order não encontrado");
            }
            else{
                context.order.Remove(o);
                await context.SaveChangesAsync();
                return Ok("Removido com sucesso!");
            }
        }
        

        private async Task<Customer> CustomerName(string name)
        {
            return await context.customer.Where(x=>x.name == name).FirstOrDefaultAsync();
        }

        private Order OrderId(int id)
        {
            return context.order.Include(x=>x.itens).Where(y=>y.id == id).FirstOrDefault();
        }
    }
}