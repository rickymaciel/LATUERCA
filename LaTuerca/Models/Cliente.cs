using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar la razon social")]
        [StringLength(100, ErrorMessage = "El { 0} debe ser al menos {2} caracteres.", MinimumLength = 6)]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Debe ingresar el documento")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Debe ingresar el email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar la direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar celular")]
        public string Celular { get; set; }

        public int LimiteCredito { get; set; }

        public string FormaPago { get; set; }

        public string TipoCliente { get; set; }

        public DateTime FechaAlta { get; set; }

        public Boolean estado { get; set; }
    }
}