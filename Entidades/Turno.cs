﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preinscripcion.Entidades
{
    [Table("Turno")]
    public class Turno
    {
        [Key]
        public int TurnoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Boolean Estado { get; set; }

    }

}
