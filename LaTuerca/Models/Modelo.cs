using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Modelo
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(100, ErrorMessage = "El { 0} debe ser al menos {2} caracteres.", MinimumLength = 6)]
        public string NombreModelo { get; set; }

        public Boolean Estado { get; set; }
    }
}