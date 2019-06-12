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
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return _userRepository.GetAllItems();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
