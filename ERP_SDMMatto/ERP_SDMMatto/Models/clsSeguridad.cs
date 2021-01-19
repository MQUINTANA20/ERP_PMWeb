using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_SDMMatto.Models
{
    public class clsSeguridad
    {
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        [Display(Name = "Sucursal")]
        public int CatSucursalesSelect { get; set; }

        [Display(Name = "Sucursal")]
        public IEnumerable<SelectListItem> CatSucursales { get; set; }

        


    }

    public class clsPermisosUsr
    {
        public string Grupo { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }
        public int  Valor { get; set; }
        public string Descripcion { get; set; }

        public string Clase { get; set; }


        public int Editar { get; set; }
    }

}