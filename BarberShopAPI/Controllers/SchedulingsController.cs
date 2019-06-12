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
    public class SchedulingsController : Controller
    {
        private readonly SchedulingRepository _schedulingRepository;

        public SchedulingsController(SchedulingRepository schedulingRepository)
        {
            _schedulingRepository = schedulingRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Scheduling>> GetSchedulings()
        {
            return _schedulingRepository.GetAllItems();
        }

        [HttpGet]
        public Scheduling GetScheduling(int id)
        {
            return _schedulingRepository.GetById(id);
        }

        [HttpPut]
        public void UpdateScheduling(Scheduling scheduling)
        {
            _schedulingRepository.Update(scheduling);
        }

        [HttpPost]
        public void CreateScheduling(Scheduling scheduling)
        {
            _schedulingRepository.Create(scheduling);
        }

        [HttpDelete]
        public void DeleteScheduling(int id)
        {
            _schedulingRepository.Delete(id);
        }
    }
}
