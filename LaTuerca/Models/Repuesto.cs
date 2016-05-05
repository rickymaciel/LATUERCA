using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Repuesto
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Referencia { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Img { get; set; }
        public int CategoriaID { get; set; }
        public int MarcaID { get; set; }
        public int ModeloID { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public float PrecioCosto { get; set; }
        public float PrecioVenta1 { get; set; }
        public float PrecioVenta2 { get; set; }
        public float PrecioVenta3 { get; set; }
    }
}