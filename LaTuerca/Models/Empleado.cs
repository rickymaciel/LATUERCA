using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace LaTuerca.Models
{
    public class Empleado
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string NroFuncionario { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int Documento { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Rol { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }

        public Boolean Estado { get; set; }
    }
}