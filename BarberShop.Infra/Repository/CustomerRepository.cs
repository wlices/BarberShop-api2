using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BarberShopAPI.Infra.Context;
using BarberShopAPI.Infra.Models;

namespace BarberShopAPI.Infra.Repository
{
    public class CustomerRepository
    {
        private readonly BarberShopContext _context;

        public CustomerRepository(BarberShopContext context)
        {
            _context = context;
        }

        // Get all
        public async Task<IEnumerable<Customer>> GetAllItems()
        {
            return await _context.Customers.ToListAsync();
        }

        //GetById
        public Customer GetById(int id)
        {
            return _context.Customers.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        //Update
        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();   
        }

        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            Customer Customer = _context.Customers.Find(id);
            _context.Customers.Remove(Customer);
            _context.SaveChanges();
        }
    }
}
