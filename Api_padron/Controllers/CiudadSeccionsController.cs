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
    public class CiudadSeccionsController : ControllerBase
    {
        private readonly cedulaContext _context;

        public CiudadSeccionsController(cedulaContext context)
        {
            _context = context;
        }

        // GET: api/CiudadSeccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CiudadSeccion>>> GetCiudadSeccions()
        {
          if (_context.CiudadSeccions == null)
          {
              return NotFound();
          }
            return await _context.CiudadSeccions.ToListAsync();
        }

        // GET: api/CiudadSeccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CiudadSeccion>> GetCiudadSeccion(short id)
        {
          if (_context.CiudadSeccions == null)
          {
              return NotFound();
          }
            var ciudadSeccion = await _context.CiudadSeccions.FindAsync(id);

            if (ciudadSeccion == null)
            {
                return NotFound();
            }

            return ciudadSeccion;
        }

        // PUT: api/CiudadSeccions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudadSeccion(short id, CiudadSeccion ciudadSeccion)
        {
            if (id != ciudadSeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(ciudadSeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadSeccionExists(id))
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

        // POST: api/CiudadSeccions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CiudadSeccion>> PostCiudadSeccion(CiudadSeccion ciudadSeccion)
        {
          if (_context.CiudadSeccions == null)
          {
              return Problem("Entity set 'cedulaContext.CiudadSeccions'  is null.");
          }
            _context.CiudadSeccions.Add(ciudadSeccion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CiudadSeccionExists(ciudadSeccion.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCiudadSeccion", new { id = ciudadSeccion.Id }, ciudadSeccion);
        }

        // DELETE: api/CiudadSeccions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudadSeccion(short id)
        {
            if (_context.CiudadSeccions == null)
            {
                return NotFound();
            }
            var ciudadSeccion = await _context.CiudadSeccions.FindAsync(id);
            if (ciudadSeccion == null)
            {
                return NotFound();
            }

            _context.CiudadSeccions.Remove(ciudadSeccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CiudadSeccionExists(short id)
        {
            return (_context.CiudadSeccions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
