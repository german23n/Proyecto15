﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto15.models
{
    public class Categoria
    {

        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
