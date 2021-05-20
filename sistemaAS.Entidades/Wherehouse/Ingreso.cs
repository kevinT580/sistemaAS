﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace sistemaAS.Entidades.Wherehouse
{
    public class Ingreso
    {

        public int idIngreso { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]

        public int idProveedor { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public int idUsuario { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public string tipoComprobante { get; set; }
        [StringLength(20)]
        public string serieComprobante { get; set; }
        [StringLength(7)]
        public string numComprobante { get; set; }
        [StringLength(10)]
        public DateTime fechaHora { get; set; }
        public string impuesto { get; set; }
        [StringLength(50)]
        public string total { get; set; }
        [StringLength(50)]
        public string estado { get; set; }
    }
}