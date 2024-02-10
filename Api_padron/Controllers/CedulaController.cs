using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_padron.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CedulaController : ControllerBase
    {
        private readonly cedulaContext _context;
        public CedulaController( cedulaContext context) { 
        
            _context = context;
        }
        // GET: api/<CedulaController>
        [HttpGet]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PadronFilterParameters filters)
        {
            IQueryable<Padron> query = _context.Padrons;

            // Aplicar filtros si se proporcionan
            if (filters != null)
            {
                if (!string.IsNullOrEmpty(filters.Cedula))
                {
                    query = query.Where(p => p.Cedula == filters.Cedula);
                }

                if (!string.IsNullOrEmpty(filters.Nombres))
                {
                    query = query.Where(p => p.Nombres == filters.Nombres);
                }

                if (!string.IsNullOrEmpty(filters.Apellido1))
                {
                    query = query.Where(p => p.Apellido1 == filters.Apellido1);
                }

                if (!string.IsNullOrEmpty(filters.Apellido2))
                {
                    query = query.Where(p => p.Apellido2 == filters.Apellido2);
                }

                if (filters.FechaNacimiento.HasValue)
                {
                    query = query.Where(p => p.FechaNacimiento == filters.FechaNacimiento);
                }

                if (filters.IdNacionalidad.HasValue)
                {
                    query = query.Where(p => p.IdNacionalidad == filters.IdNacionalidad);
                }

                if (!string.IsNullOrEmpty(filters.IdSexo))
                {
                    query = query.Where(p => p.IdSexo == filters.IdSexo);
                }

                if (!string.IsNullOrEmpty(filters.IdEstadoCivil))
                {
                    query = query.Where(p => p.IdEstadoCivil == filters.IdEstadoCivil);
                }

                if (filters.IdCategoria.HasValue)
                {
                    query = query.Where(p => p.IdCategoria == filters.IdCategoria);
                }

                if (filters.IdCausaCancelacion.HasValue)
                {
                    query = query.Where(p => p.IdCausaCancelacion == filters.IdCausaCancelacion);
                }

                if (filters.IdColegio.HasValue)
                {
                    query = query.Where(p => p.IdColegio == filters.IdColegio);
                }

                if (filters.IdColegioOrigen.HasValue)
                {
                    query = query.Where(p => p.IdColegioOrigen == filters.IdColegioOrigen);
                }

                if (filters.IdMunicipioOrigen.HasValue)
                {
                    query = query.Where(p => p.IdMunicipioOrigen == filters.IdMunicipioOrigen);
                }

                if (!string.IsNullOrEmpty(filters.ColegioOrigen))
                {
                    query = query.Where(p => p.ColegioOrigen == filters.ColegioOrigen);
                }

                if (filters.PosPagina.HasValue)
                {
                    query = query.Where(p => p.PosPagina == filters.PosPagina);
                }
            }

            // Ejecutar la consulta y devolver los resultados
            List<Padron> results = await query.ToListAsync();
            return Ok(results);
        }
    

    public class PadronFilterParameters
    {
        public string? Cedula { get; set; }
        public string? Nombres { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdNacionalidad { get; set; }
        public string? IdSexo { get; set; }
        public string? IdEstadoCivil { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdCausaCancelacion { get; set; }
        public int? IdColegio { get; set; }
        public int? IdColegioOrigen { get; set; }
        public int? IdMunicipioOrigen { get; set; }
        public string? ColegioOrigen { get; set; }
        public int? PosPagina { get; set; }
    }
    // GET api/<CedulaController>/5
    [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CedulaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CedulaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CedulaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
