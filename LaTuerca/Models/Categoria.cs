using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Categoria
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(100, ErrorMessage = "El { 0} debe ser al menos {2} caracteres.", MinimumLength = 6)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una unidad de medida")]
        public string Unidad { get; set; }

        [Required(ErrorMessage = "Debe ingresar cilindrada")]
        public string Cilindrada { get; set; }

        [Required(ErrorMessage = "Debe ingresar tipo de motor")]
        public string TipoMotor { get; set; }

        public Boolean Estado { get; set; }
    }
}