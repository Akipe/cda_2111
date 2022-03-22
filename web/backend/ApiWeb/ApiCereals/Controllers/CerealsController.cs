#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCereals;
using ApiCereals.Models;

namespace ApiCereals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CerealsController : ControllerBase
    {
        private readonly CerealDbContext _context;

        public CerealsController(CerealDbContext context)
        {
            _context = context;
        }

        // GET: api/Cereals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cereal>>> GetCereals()
        {
            return await _context.Cereals.ToListAsync();
        }

        // GET: api/Cereals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cereal>> GetCereal(int id)
        {
            var cereal = await _context.Cereals.FindAsync(id);

            if (cereal == null)
            {
                return NotFound();
            }

            return cereal;
        }

        // PUT: api/Cereals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCereal(int id, Cereal cereal)
        {
            if (id != cereal.Id)
            {
                return BadRequest();
            }

            _context.Entry(cereal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CerealExists(id))
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

        // POST: api/Cereals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cereal>> PostCereal(Cereal cereal)
        {
            _context.Cereals.Add(cereal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCereal", new { id = cereal.Id }, cereal);
        }

        // DELETE: api/Cereals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCereal(int id)
        {
            var cereal = await _context.Cereals.FindAsync(id);
            if (cereal == null)
            {
                return NotFound();
            }

            _context.Cereals.Remove(cereal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CerealExists(int id)
        {
            return _context.Cereals.Any(e => e.Id == id);
        }
    }
}
