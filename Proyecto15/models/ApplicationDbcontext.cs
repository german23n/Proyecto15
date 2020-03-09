using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto15.models
{
    public class ApplicationDbcontext : DbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }


        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<CategoriaSubCategoria> CategoriaSubCategorias { get; set; }
    }
}
