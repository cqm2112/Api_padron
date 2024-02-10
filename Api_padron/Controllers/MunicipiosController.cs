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
    public class MunicipiosController : ControllerBase
    {
        private readonly cedulaContext _context;

        public MunicipiosController(cedulaContext context)
        {
            _context = context;
        }

        // GET: api/Municipios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipios()
        {
          if (_context.Municipios == null)
          {
              return NotFound();
          }
            return await _context.Municipios.ToListAsync();
        }

        // GET: api/Municipios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipio>> GetMunicipio(short id)
        {
          if (_context.Municipios == null)
          {
              return NotFound();
          }
            var municipio = await _context.Municipios.FindAsync(id);

            if (municipio == null)
            {
                return NotFound();
            }

            return municipio;
        }

        // PUT: api/Municipios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMunicipio(short id, Municipio municipio)
        {
            if (id != municipio.Id)
            {
                return BadRequest();
            }

            _context.Entry(municipio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MunicipioExists(id))
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

        // POST: api/Municipios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Municipio>> PostMunicipio(Municipio municipio)
        {
          if (_context.Municipios == null)
          {
              return Problem("Entity set 'cedulaContext.Municipios'  is null.");
          }
            _context.Municipios.Add(municipio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MunicipioExists(municipio.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMunicipio", new { id = municipio.Id }, municipio);
        }

        // DELETE: api/Municipios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMunicipio(short id)
        {
            if (_context.Municipios == null)
            {
                return NotFound();
            }
            var municipio = await _context.Municipios.FindAsync(id);
            if (municipio == null)
            {
                return NotFound();
            }

            _context.Municipios.Remove(municipio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MunicipioExists(short id)
        {
            return (_context.Municipios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
