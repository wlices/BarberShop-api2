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
    public class UserRepository
    {
        private readonly BarberShopContext _context;

        public UserRepository(BarberShopContext context)
        {
            _context = context;
        }

        // Get all
        public async Task<IEnumerable<User>> GetAllItems()
        {
            return await _context.Users.ToListAsync();
        }

        //GetById
        public User GetById(int id)
        {
            return _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        //Update
        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}

