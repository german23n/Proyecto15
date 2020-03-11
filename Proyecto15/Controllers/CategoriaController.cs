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

        
    }
}
