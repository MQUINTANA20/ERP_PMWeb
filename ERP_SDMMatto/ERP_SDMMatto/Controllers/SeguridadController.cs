using ERP_SDMMatto.Models;
using ERP_SDMMatto.Properties;
using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace ERP_SDMMatto.Controllers
{
    public class SeguridadController : BaseController
    {
        // GET: Seguridad
        ERPEntity_1 entity = new ERPEntity_1();
        public ActionResult Index()
        {
            var clsUsr = new Models.clsSeguridad();

            var lstSucursales = new SelectList(new List<string>());
         
            //De la siguiente manera llenamos manualmente,
            //Siendo el campo Text lo que ve el usuario y
            //el campo Value lo que en realidad vale nuestro valor
          

            clsUsr.CatSucursales = lstSucursales;
            clsUsr.CatSucursalesSelect = 1;
            return View(clsUsr);
        }

        public ActionResult ValidaUsuario(clsSeguridad objSeguridad)
        {

            var lstSucursales = new SelectList(new List<string>());


            try
            {

                  

                var msgSP  = entity.Database.SqlQuery<clsMensajesSP>("call spUsuario({0},{1},{2},{3},{4})", new object[] { objSeguridad.Usuario, objSeguridad.Contrasena, "1", objSeguridad.CatSucursalesSelect.ToString(), "0"} ).ToList();
                
                //Evaluamos si existe el usuario en la base
                if (msgSP != null && msgSP.Count() > 0)
                {


                    Warning(msgSP[0].msg);
                    
                }
                else if(msgSP != null && msgSP.Count() == 0)
                {
                    //Si encuentra el usuario
                    //if (objSeguridad.CatSucursalesSelect != 3 || objSeguridad.CatSucursalesSelect != 4)

                  
                        //validamos permisos de ususario
                        var permisos = entity.Database.SqlQuery<clsPermisosUsr>("call spUsuarioPermiso({0},{1})", new object[] { objSeguridad.Usuario, "1" }).ToList();
                        if (permisos != null && permisos.Count() > 0)
                        {
                            var nombre = permisos.Where(p => p.Nombre == "PMServicioDomicilio").Select(p => p.Nombre);

                            if ((permisos[0].Grupo == "SD-TECNICO" &&  nombre.Count() >0) || permisos[0].Grupo == "ADMINISTRADOR"){
                            var usrSuc = (from s in entity.sucursals
                                          where s.Sucursal1 == objSeguridad.CatSucursalesSelect
                                          select s).FirstOrDefault();
                            var usrData = (from u in entity.usuarios
                                           where u.Usuario1 == objSeguridad.Usuario
                                           select u).FirstOrDefault();

                          
                            Session["Usuario"] = objSeguridad.Usuario;
                            Session["UserName"] = usrData.Nombre;
                            Session["UsrSucursal"] =usrSuc.Nombre;
                            Session["IdSuc"] = usrSuc.Sucursal1;

                                return RedirectToAction("Index", "SDM");
                            }
                            else
                            {
                                Warning("No tiene permisos para acceder a la aplicación.Favor contacte al administrador del sistema");
                            }
                        }
                       
                       
                            
                    }
                   

                   
                  
                
               
            }
            catch(Exception e)
            {
                Danger(Resources.MsjError + " - [" + e.Message + "]");
            }
           
            //De la siguiente manera llenamos manualmente,
            //Siendo el campo Text lo que ve el usuario y
            //el campo Value lo que en realidad vale nuestro valor


            objSeguridad.CatSucursales = lstSucursales;
            objSeguridad.CatSucursalesSelect = 1;
            return View("Index", objSeguridad);
        }

        public ActionResult Logout()
        {
            try
            {
               
                FormsAuthentication.SignOut();
                Session.Abandon();
                Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

                return RedirectToAction("Index", "Seguridad");

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Seguridad");
            }

        }

        public JsonResult GetSucursales(string usuario)
        {
            List<string> sucursales = new List<string>();
            try
            {
                var usrParam = new MySqlParameter("vg_Usuario", usuario);
                var empresaParam = new MySqlParameter("vg_empresa", 1);
                
                MySqlParameter[] lstPatram = new MySqlParameter[] { usrParam, empresaParam };

                var selectSuc = entity.Database.SqlQuery<clsSucursales>($"Call spUsuarioSucursalGet(@vg_Usuario,@vg_empresa)", lstPatram).ToList();

                


                if (selectSuc != null)
                {
                    foreach(var item in selectSuc)
                    {
                        sucursales.Add(item.Sucursal.ToString() + "-" + item.Nombre);

                    }
                }

            }
            catch (Exception e)
            {
                Danger("Error" + e.Message);

            }

            return Json(sucursales, JsonRequestBehavior.AllowGet);
        }
    }
}