using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto15.models
{
    public class Institucion
    {
        [Key]
        public int IdInstitucion { get; set; }
        public string RazonSocial { get; set; }
        public string Alias { get; set; }
        public Grupo IdGrupo { get; set; }
        public CategoriaSubCategoria IdCategoriaSubCategoria { get; set; }

        


    }
}
