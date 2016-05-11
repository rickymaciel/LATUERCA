using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Repuesto
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre")]
        [StringLength(100, ErrorMessage = "El { 0} debe ser al menos {2} caracteres.", MinimumLength = 6)]
        public string Nombre { get; set; }

        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public float Costo { get; set; }
        public float Venta1 { get; set; }
        public float Venta2 { get; set; }
        public float Venta3 { get; set; }
        public string Img { get; set; }

        public int ProveedorId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey("ProveedorId")]
        public virtual Proveedor Proveedor { get; set; }

        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }

        [ForeignKey("ModeloId")]
        public virtual Modelo Modelo { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

    }
}