using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto15.models
{
    public class SubCategoria
    {
        [Key]
        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; }
        public List<CategoriaSubCategoria> CategoriaSubCategorias { get; set; }

    }
}
