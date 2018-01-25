﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preinscripcion.Entidades
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        public string Nombre { get; set; } 
    }   
}
