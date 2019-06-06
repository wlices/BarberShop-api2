using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarberShopAPI.Infra.Models;
using BarberShopAPI.Models;

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulingsController : ControllerBase
    {
        private readonly BarberShopAPIContext _context;

        public SchedulingsController(BarberShopAPIContext context)
        {
            _context = context;
        }

        // GET: api/Schedulings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scheduling>>> GetScheduling()
        {
            return await _context.Scheduling.ToListAsync();
        }

        // GET: api/Schedulings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scheduling>> GetScheduling(int id)
        {
            var scheduling = await _context.Scheduling.FindAsync(id);

            if (scheduling == null)
            {
                return NotFound();
            }

            return scheduling;
        }

        // PUT: api/Schedulings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScheduling(int id, Scheduling scheduling)
        {
            if (id != scheduling.Id)
            {
                return BadRequest();
            }

            _context.Entry(scheduling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchedulingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Schedulings
        [HttpPost]
        public async Task<ActionResult<Scheduling>> PostScheduling(Scheduling scheduling)
        {
            _context.Scheduling.Add(scheduling);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScheduling", new { id = scheduling.Id }, scheduling);
        }

        // DELETE: api/Schedulings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Scheduling>> DeleteScheduling(int id)
        {
            var scheduling = await _context.Scheduling.FindAsync(id);
            if (scheduling == null)
            {
                return NotFound();
            }

            _context.Scheduling.Remove(scheduling);
            await _context.SaveChangesAsync();

            return scheduling;
        }

        private bool SchedulingExists(int id)
        {
            return _context.Scheduling.Any(e => e.Id == id);
        }
    }
}
