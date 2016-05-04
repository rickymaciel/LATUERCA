using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Proveedores
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Ruc { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string FormaPago { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public Boolean estado { get; set; }
        public Boolean esAcreedor { get; set; }
    }
}