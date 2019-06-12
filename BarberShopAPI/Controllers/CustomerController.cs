using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarberShopAPI.Infra.Models;
using BarberShopAPI.Infra.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public Task<IEnumerable<Customer>> GetCustomers()
        {
            return _customerRepository.GetAllItems();
        }

        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetById(id);
        }

        [HttpPut]
        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        [HttpPost]
        public void CreateCustomer(Customer customer)
        {
            _customerRepository.Create(customer);
        }

        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            _customerRepository.Delete(id);
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
