using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopAPI.Infra.Context;
using BarberShopAPI.Infra.Models;

namespace BarberShopAPI.Infra.Repository
{
    public class CustomerRepository
    {
        private readonly BarberShopContext _context = new BarberShopContext();


        public async Task<IEnumerable<Customer>> GetAllItems()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
