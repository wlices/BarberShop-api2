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
    public class SchedulingRepository
    {
        private readonly BarberShopContext _context;

        public SchedulingRepository(BarberShopContext context)
        {
            _context = context;
        }

        // Get all
        public async Task<IEnumerable<Scheduling>> GetAllItems()
        {
            return await _context.Schedulings.ToListAsync();
        }

        //GetById
        public Scheduling GetById(int id)
        {
            return _context.Schedulings.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        //Update
        public void Update(Scheduling scheduling)
        {
            _context.Entry(scheduling).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Create(Scheduling scheduling)
        {
            _context.Schedulings.Add(scheduling);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Scheduling scheduling = _context.Schedulings.Find(id);
            _context.Schedulings.Remove(scheduling);
            _context.SaveChanges();
        }
    }
}

