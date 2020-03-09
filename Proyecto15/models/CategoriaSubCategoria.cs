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
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public SubCategoria SubCategoria { get; set; }

    }
}

