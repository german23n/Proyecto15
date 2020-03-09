using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto15.models;

namespace Proyecto15.Controllers
{
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ApplicationDbcontext _context;

        public CategoriaController(ApplicationDbcontext context)
        {
            _context = context;
        }
        // GET: api/Categoria
        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categoria;
        }

        // GET: api/Categoria/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categoria
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Categoria/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
