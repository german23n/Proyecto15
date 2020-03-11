using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto15.models;

namespace Proyecto15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSCController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public CSCController(ApplicationDbcontext context)
        {
            _context = context;
        }
        // GET: api/CSC
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
       

    }
}
