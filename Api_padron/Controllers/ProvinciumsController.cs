using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_padron.Models;

namespace Api_padron.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciumsController : ControllerBase
    {
        private readonly cedulaContext _context;

        public ProvinciumsController(cedulaContext context)
        {
            _context = context;
        }

        // GET: api/Provinciums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincium>>> GetProvincia()
        {
          if (_context.Provincia == null)
          {
              return NotFound();
          }
            return await _context.Provincia.ToListAsync();
        }

        // GET: api/Provinciums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincium>> GetProvincium(short id)
        {
          if (_context.Provincia == null)
          {
              return NotFound();
          }
            var provincium = await _context.Provincia.FindAsync(id);

            if (provincium == null)
            {
                return NotFound();
            }

            return provincium;
        }

        // PUT: api/Provinciums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincium(short id, Provincium provincium)
        {
            if (id != provincium.Id)
            {
                return BadRequest();
            }

            _context.Entry(provincium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciumExists(id))
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

        // POST: api/Provinciums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Provincium>> PostProvincium(Provincium provincium)
        {
          if (_context.Provincia == null)
          {
              return Problem("Entity set 'cedulaContext.Provincia'  is null.");
          }
            _context.Provincia.Add(provincium);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProvinciumExists(provincium.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProvincium", new { id = provincium.Id }, provincium);
        }

        // DELETE: api/Provinciums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvincium(short id)
        {
            if (_context.Provincia == null)
            {
                return NotFound();
            }
            var provincium = await _context.Provincia.FindAsync(id);
            if (provincium == null)
            {
                return NotFound();
            }

            _context.Provincia.Remove(provincium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProvinciumExists(short id)
        {
            return (_context.Provincia?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
