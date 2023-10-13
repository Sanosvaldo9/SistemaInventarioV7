﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemainventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser Maximo de 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es requerido")]
        [MaxLength(60, ErrorMessage = "Descripcion debe ser Maximo de 60 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }
    }
}
