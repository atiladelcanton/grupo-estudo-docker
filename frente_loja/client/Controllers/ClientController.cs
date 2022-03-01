using System.Collections.Generic;
using client.Data;
using client.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace apiorder.Controllers
{

    [Controller]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private DataContext context;

        public ClientController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("/")]
        public string home()
        {
            return "Grupo de estudo";
        }


        [HttpPost("add")]
        public async Task<ActionResult> Add([FromBody] Client requestClient)
        {
            try
            {
                requestClient.createdAt = DateTime.Now;
                context.client.Add(requestClient);
                await context.SaveChangesAsync();
                return Created("Create Clinet",requestClient);
            }
            catch(Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult> List()
        {
            //return Ok(await context.order.Include(x=>x.itens).Include(y=>y.customer).ToListAsync());
            return Ok(await context.client.ToListAsync());
        }


        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Del(int id)
        {
            Client c = ClientId(id);
            if(c==null) {
                return NotFound("Client not found");
            }
            else{
                context.client.Remove(c);
                await context.SaveChangesAsync();
                return Ok("Removido com sucesso!");
            }
        }

        private Client ClientId(int id)
        {
            return context.client.Where(y=>y.id == id).FirstOrDefault();
        }
    }
}