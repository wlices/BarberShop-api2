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
    public class ServiceRepository
    {
        private readonly BarberShopContext _context;

        public ServiceRepository(BarberShopContext context)
        {
            _context = context;
        }

        // Get all
        public async Task<IEnumerable<Service>> GetAllItems()
        {
            return await _context.Services.ToListAsync();
        }

        //GetById
        public Service GetById(int id)
        {
            return _context.Services.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        //Update
        public void Update(Service service)
        {
            _context.Entry(service).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Create(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Service Service = _context.Services.Find(id);
            _context.Services.Remove(Service);
            _context.SaveChanges();
        }
    }
}

