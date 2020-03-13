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

    [Route("api/CategoriaSubCategorias")]
    [ApiController]
    public class CategoriaSubCategoriasController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public CategoriaSubCategoriasController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: api/CategoriaSubCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaSubCategoria>>> GetCategoriaSubCategorias()
        {
            return await _context.CategoriaSubCategorias.Include(x=>x.IdCategoria).ToListAsync();
        }

        // GET: api/CategoriaSubCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaSubCategoria>> GetCategoriaSubCategoria(int id)
        {
            var categoriaSubCategoria = await _context.CategoriaSubCategorias.FindAsync(id);

            if (categoriaSubCategoria == null)
            {
                return NotFound();
            }

            return categoriaSubCategoria;
        }

        // PUT: api/CategoriaSubCategorias/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaSubCategoria(int id, CategoriaSubCategoria categoriaSubCategoria)
        {
            if (id != categoriaSubCategoria.IdCategoriaSubCategoria)
            {
                return BadRequest();
            }

            _context.Entry(categoriaSubCategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaSubCategoriaExists(id))
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

        // POST: api/CategoriaSubCategorias
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CategoriaSubCategoria>> PostCategoriaSubCategoria(CategoriaSubCategoria categoriaSubCategoria)
        {
            _context.CategoriaSubCategorias.Add(categoriaSubCategoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoriaSubCategoria", new { id = categoriaSubCategoria.IdCategoriaSubCategoria }, categoriaSubCategoria);
        }

        // DELETE: api/CategoriaSubCategorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriaSubCategoria>> DeleteCategoriaSubCategoria(int id)
        {
            var categoriaSubCategoria = await _context.CategoriaSubCategorias.FindAsync(id);
            if (categoriaSubCategoria == null)
            {
                return NotFound();
            }

            _context.CategoriaSubCategorias.Remove(categoriaSubCategoria);
            await _context.SaveChangesAsync();

            return categoriaSubCategoria;
        }

        private bool CategoriaSubCategoriaExists(int id)
        {
            return _context.CategoriaSubCategorias.Any(e => e.IdCategoriaSubCategoria == id);
        }
    }
}
