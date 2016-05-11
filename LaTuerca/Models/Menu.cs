using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Menu
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        public virtual int PadreId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del menú")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar la descripción del menú")]
        public string Descripcion { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public Boolean Estado { get; set; }

        public List<Menu> Children()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Menus.Where(b => b.PadreId == this.Id).ToList();
        }
    }
}