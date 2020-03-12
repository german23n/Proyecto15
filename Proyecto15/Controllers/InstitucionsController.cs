using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto15.models;

namespace Proyecto15.Controllers
{
    [Route("api/Institucion")]
    [ApiController]
    public class InstitucionsController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public InstitucionsController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: api/Institucions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Institucion>>> GetInstituciones()
        {
            return await _context.Instituciones.Include(x => x.IdGrupo ).Include(x=> x.IdCategoriaSubCategoria).ToListAsync();
        }

        // GET: api/Institucions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Institucion>> GetInstitucion(int id)
        {
            var institucion = await _context.Instituciones.FindAsync(id);

            if (institucion == null)
            {
                return NotFound();
            }

            return institucion;
        }

        // PUT: api/Institucions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstitucion(int id, Institucion institucion)
        {
            if (id != institucion.IdInstitucion)
            {
                return BadRequest();
            }

            _context.Entry(institucion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitucionExists(id))
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

        // POST: api/Institucions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Institucion>> PostInstitucion(Institucion institucion)
        {
            _context.Instituciones.Add(institucion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstitucion", new { id = institucion.IdInstitucion }, institucion);
        }

        // DELETE: api/Institucions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Institucion>> DeleteInstitucion(int id)
        {
            var institucion = await _context.Instituciones.FindAsync(id);
            if (institucion == null)
            {
                return NotFound();
            }

            _context.Instituciones.Remove(institucion);
            await _context.SaveChangesAsync();

            return institucion;
        }

        private bool InstitucionExists(int id)
        {
            return _context.Instituciones.Any(e => e.IdInstitucion == id);
        }
    }
}
