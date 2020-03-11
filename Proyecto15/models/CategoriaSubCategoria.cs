using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto15.models
{
    public class CategoriaSubCategoria
    {

        [Key]
        public int IdCategoriaSubCategoria { get; set; }
    
        public Categoria IdCategoria { get; set; }
        public SubCategoria IdSubCategoria { get; set; }

    }
}

