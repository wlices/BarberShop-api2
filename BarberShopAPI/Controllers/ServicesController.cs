using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarberShopAPI.Infra.Models;
using BarberShopAPI.Infra.Repository;

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        private readonly ServiceRepository _serviceRepository;

        public ServicesController(ServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Service>> GetServices()
        {
            return _serviceRepository.GetAllItems();
        }

        [HttpGet]
        public Service GetService(int id)
        {
            return _serviceRepository.GetById(id);
        }

        [HttpPut]
        public void UpdateService(Service service)
        {
            _serviceRepository.Update(service);
        }

        [HttpPost]
        public void CreateService(Service service)
        {
            _serviceRepository.Create(service);
        }

        [HttpDelete]
        public void DeleteService(int id)
        {
            _serviceRepository.Delete(id);
        }
    }
}
