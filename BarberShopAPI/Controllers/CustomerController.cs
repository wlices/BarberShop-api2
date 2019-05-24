using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarberShopAPI.Infra.Context;
using BarberShopAPI.Infra.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var contexto = new BarberShopContext();
            var items = contexto.Customers.ToList();

            return items;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
