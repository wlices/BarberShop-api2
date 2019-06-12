using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarberShopAPI.Infra.Models;
using BarberShopAPI.Models;
using BarberShopAPI.Infra.Repository;

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public Task<IEnumerable<User>> GetUsers()
        {
            return _userRepository.GetAllItems();
        }

        [HttpGet]
        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        [HttpPost]
        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
