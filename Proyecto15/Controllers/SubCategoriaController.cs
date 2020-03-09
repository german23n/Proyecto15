using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto15.models;

namespace Proyecto15.Controllers
{
    [Route("api/SubCategoria")]
    [ApiController]
    public class SubCategoriaController : ControllerBase

    {


        private readonly ApplicationDbcontext _context;

        public SubCategoriaController(ApplicationDbcontext context)
        {
            _context = context;
        }
        // GET: api/SubCategoria
        [HttpGet]
        public IEnumerable<SubCategoria> Get()
        {
            return _context.SubCategorias;
        }

       
    }
}
