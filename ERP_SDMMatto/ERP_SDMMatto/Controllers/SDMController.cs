using ERP_SDMMatto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Data.Entity.Core.Objects.DataClasses;
using ERP_SDMMatto.Properties;
using System.Web.Services;
using System.Web.Script.Services;
using System.Windows.Forms;
using System.Web.WebPages.Html;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using System.Data.Entity.Core.Objects;
using System.Data;

namespace ERP_SDMMatto.Controllers.Matto
{
    public class SDMController :  BaseController
    {

        // GET: SDM
        ERPEntity_1 entity = new ERPEntity_1();
        public static string usrs = "";
        public ActionResult Index()
        {
            clsUnidad objUunidad = new clsUnidad();
            try
            {
                /* JJM Solo perfil de súper administrador tiene acceso a este modulo*/
                if (Session["Usuario"] != null)
                {

                    usrs = Session["Usuario"].ToString();

                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch(Exception e)
            {
                RedirectToAction("Index", "Seguridad");
            }
                    return View();
        }

        //Get Unidad e Items
        [HttpPost]
        public JsonResult BuscaUnidad()
        {
             List<string> result = new List<string>();
            
            //try
            //{
             if(Session["Usuario"] != null){

                    
                   var usr = Session["Usuario"].ToString();
                var suc = int.Parse(Session["IdSuc"].ToString());
                    List<string> nombre = (from u in entity.usuarios
                                  join g in entity.grupoconfs on u.GrupoTrabajo equals g.Grupo
                                  join d in entity.grupoconfds on g.Grupo equals d.Grupo
                                  where u.Usuario1 == usr && d.Clase == "Movimiento" && d.Tipo == "MANTTO" && d.Valor == true
                                  select d.Nombre).ToList();

                    if (nombre.Count() > 0) {
                        var resultSp = (from m in entity.manttoes
                                        join ms in entity.manttoservicios on m.ID equals ms.ID
                                        join c in entity.contactoes on m.AgenteE equals c.Contacto1 into ps
                                        where m.Empresa == 1 && nombre.Contains(m.Mov)
                                        && m.Sucursal == suc  && m.Estatus == "PENDIENTE" && m.Mov == "Ord Serv MODELO"
                                        orderby m.ID
                                        from c in ps.DefaultIfEmpty()
                                        select new {
                                            m.ID,
                                            ms.NoEconomico,
                                            ms.Tipo,
                                            ms.Modelo,
                                            ms.Marca,
                                            ms.Ano,
                                            ms.Placas,
                                            ms.KM,
                                            ms.Color,
                                            ms.Serie,
                                            ms.Capacidad,
                                            ms.NoMotor,
                                            m.Mov,
                                            m.Folio,
                                            ms.FechaVenta
                                        });
                        resultSp = resultSp.Distinct().Take(1000);
                        var finalConsult = resultSp.ToList();

                        if (finalConsult.Count() > 0)
                        {

                           foreach(var item in finalConsult)
                            {
                                                              
                                result.Add(item.ID + "-" + "NoEconomico: " + item.NoEconomico + " - Tipo: " + item.Tipo + "- Modelo:" + item.Modelo + " - Serie: " +item.Serie + " - KM:" + item.KM);
                               
                                
                            }
                           

                        }
                        else
                        {
                           // Warning("No existe información para los datos capturados. Intente nuevamente");
                         
                        }
                    }




            }
            else
            {
                RedirectToAction("Index", "Seguridad");
            }

            return Json(result, JsonRequestBehavior.AllowGet);
            

        }

        [HttpPost]
        public JsonResult BuscaUnidadOS()
        {
            List<string> result = new List<string>();

            //try
            //{
            if (Session["Usuario"] != null)
            {


                var usr = Session["Usuario"].ToString();
                var suc = int.Parse(Session["IdSuc"].ToString());
                var consult1 = (from m in entity.manttoes
                               where m.Equipo != null
                               && m.Estatus == "PENDIENTE"
                               select m.Equipo).ToList();
                string []operadorO = new[] { "P34", "C1798" };

                var consultUnidades = (from m in entity.manttoequipoes
                                       where operadorO.Contains(m.OperadorOmision)
                                       && consult1.Contains(m.Serie)
                                       && m.Cliente == "Modelo"
                                       select m
                                       ).ToList();

                if (consultUnidades != null && consultUnidades.Count() > 0)
                {
                    

                        foreach (var item in consultUnidades)
                        {

                            result.Add(item.Clave + "-" + "NoEconomico: " + item.NoEconomico + " - Descripcion: " + item.Descripcion + "- Marca:" + item.Marca + " - Modelo: " + item.Modelo + " - Placas:" + item.Placas + " - Color:" + item.Color + " - TipoVeh:" + item.TipoVeh + " - Año:" + item.Ano);


                        }


                    }
                    else
                    {
                        // Warning("No existe información para los datos capturados. Intente nuevamente");

                    }
                }




            else
            {
                RedirectToAction("Index", "Seguridad");
            }

            return Json(result, JsonRequestBehavior.AllowGet);


        }
        public JsonResult ValidaKM(clsUnidad objUnidad)
        {
            Events msg = new Events();
            var consultU = (from s in entity.manttoservicios
                            join m in entity.manttoes on s.ID equals m.ID
                            where s.ID == objUnidad.idUnidad
                            select new { s, m }).FirstOrDefault();

            if (consultU != null)
            {
                var mov = (from m in entity.movlistas
                           where m.Modulo == "MANTTO" && m.Mov == consultU.m.Mov
                           select new { m.Clase }).FirstOrDefault();

                if (mov != null && mov.Clase == "MANTTO.OSI")
                {
                    var mantto = (from m in entity.manttoes
                                  join ml in entity.movlistas on m.Mov equals ml.Mov into ls
                                  from ml in ls.DefaultIfEmpty()
                                  where ml.Modulo == "MANTTO"
                                  join mt in entity.manttotipoes on m.MantenimientoTipo equals mt.MantenimientoTipo into t
                                  from mt in t.DefaultIfEmpty()
                                  where m.ID == objUnidad.idUnidad
                                  select new { m.Equipo, m.MantenimientoTipo, m.Servicio, mt.EsPaquete, m.OrigenModulo, m.FechaEmision }).FirstOrDefault();
                    if (mantto != null)

                    {
                        var mServicio = (from ms in entity.manttoservicios
                                         where ms.ID == objUnidad.idUnidad
                                         select ms).FirstOrDefault();



                        if (mServicio != null && mantto.Equipo != null && mantto.Equipo != "")
                        {
                            mServicio.KM = objUnidad.KM.ToString();


                            if (mantto.OrigenModulo != "UMANTTO")
                            {
                                var lastDesgaste = (from mes in entity.manttoequiposerviciohists
                                                    where mes.Clave == mantto.Equipo
                                                    orderby mes.UltimoDesgaste descending
                                                    select mes.UltimoDesgaste).FirstOrDefault();
                                int Desgaste = int.Parse(mServicio.KM.ToString());
                                if (lastDesgaste > Desgaste)
                                {
                                    msg.idMsg = "warning";
                                    msg.Msg = "El Kilometraje Capturado es Menor al Ultimo capturado en un servicio";
                                    return Json(msg, JsonRequestBehavior.AllowGet);
                                }
                                else
                                {
                                    mServicio.KM = objUnidad.KM.ToString();

                                    entity.SaveChanges();
                                    Session["KM"] = mServicio.KM;
                                    msg.idMsg = "success";
                                    msg.Msg = "El Kilometraje Capturado fue validado";

                                }



                            }
                        }


                    }




                }
            }
            else
            {
                msg.idMsg = "error";
                msg.Msg = "Unidad inválida. Verifique de favor";
            }
            return Json(msg, JsonRequestBehavior.AllowGet);
        }
        public ActionResult OpcionesUnidad(clsUnidad objUnidad)
        {
           
            clsUnidadDetalle objUnidadD = new clsUnidadDetalle();
            try
            {
                if (Session["Usuario"] != null)
                {
                   
                    var consultU = (from s in entity.manttoservicios
                                    join m in entity.manttoes on s.ID equals m.ID
                                    where s.ID == objUnidad.idUnidad
                                    select new { s, m }).FirstOrDefault();

                    if (consultU != null)
                    {
                        objUnidadD = new clsUnidadDetalle();
                        objUnidadD.Anio = consultU.s.Ano;
                        objUnidadD.Carroceria = consultU.s.Carroceria;
                        objUnidadD.Color = consultU.s.Color;
                        objUnidadD.FechaEmision = consultU.m.FechaEmision.ToString();
                        objUnidadD.Folio = consultU.m.Folio;
                        objUnidadD.Marca = consultU.s.Marca;
                        objUnidadD.Modelo = consultU.s.Modelo;
                        objUnidadD.Movimiento = consultU.m.Mov;
                        objUnidadD.NOEconomico = consultU.s.NoEconomico;
                        objUnidadD.Nombre = consultU.m.Operador;
                        objUnidadD.NOMotor = consultU.s.NoMotor;
                        objUnidadD.Placas = consultU.s.Placas;
                        objUnidadD.Serie = consultU.s.Serie;
                        objUnidadD.Servicio = consultU.m.Servicio;
                        objUnidadD.Tecnico = consultU.m.Operador;
                        objUnidadD.Tipo = consultU.s.Tipo;
                        objUnidadD.TipoMantto = consultU.m.MantenimientoTipo;
                        objUnidadD.TipoMotor = "";
                        objUnidadD.ID = objUnidad.idUnidad;



                        var agenteOmision = (from u in entity.usuarios
                                             where u.Usuario1 == usrs
                                             select new { u.AgenteOmision }).FirstOrDefault();

                        var contacto = (from c in entity.contactoes
                                        where c.Contacto1 == agenteOmision.AgenteOmision
                                        select c).FirstOrDefault();

                        if (contacto != null)
                        {
                            objUnidadD.Tecnico = agenteOmision.AgenteOmision;
                            objUnidadD.Nombre = contacto.Nombre + " " + contacto.ApellidoPaterno + " " + contacto.ApellidoMaterno;

                        }
                        else
                        {
                            objUnidadD.Tecnico = "(Sin Agente)";
                            objUnidadD.Nombre = "(Sin Agente)";
                        }

                        var manttod = (from md in entity.manttods
                                       where md.ID == objUnidad.idUnidad
                                       select md).FirstOrDefault();

                        manttod.Agente = agenteOmision.AgenteOmision;

                        entity.SaveChanges();

                     


                    }
                    else
                    {
                        Warning("La unidad no existe o esta incompleta. Verifique de favor.");
                        return RedirectToAction("Index","SDM");

                    }
                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch(Exception e)
            {
                Danger("error" + e.Message);
                return RedirectToAction("Index", "SDM");
              
            }
            return View(objUnidadD);
        }

        public ActionResult ListarQuickCheck(int? idOrden, string serieU)
        {
            
            List<clsQuickCheck> lstQC= new List<clsQuickCheck>();
            List<clsEvaluacion> lstEvaluacion = new List<clsEvaluacion>();

            try
            {

                if(Session["Usuario"] != null)
                {
                    var objCheckLst = (from qc in entity.manttoquickchecks
                                       join cqc in entity.camsolquickchecks on qc.IDInternoI equals cqc.IDInterno into cs
                                       from cqc in cs.DefaultIfEmpty()
                                       where qc.ID == idOrden
                                       select new { qc, cqc.ItemARevisar, cqc.Sistemas, cqc.Prioritario }).ToList();
                      
                    if(objCheckLst != null && objCheckLst.Count > 0)                   
                    {
                        foreach(var item in objCheckLst) 
                        {
                            
                            clsQuickCheck qc = new clsQuickCheck();
                            qc.IDInterno = item.qc.IDInternoI;
                            qc.ItemARevisar = item.ItemARevisar;
                            qc.Rojo = (bool)item.qc.Rojo == null ? false : (bool)item.qc.Rojo;
                            qc.Verde =(bool) item.qc.Verde == null  ? false : (bool) item.qc.Verde;
                            qc.Eval = (bool)item.qc.Evaluar.GetValueOrDefault();
                            qc.Comentarios = item.qc.Comentario == null ? "" : item.qc.Comentario;
                            qc.Refacciones = item.qc.RefacRequeridas;
                            qc.IDUnidad = serieU;
                            qc.IDOrden = (int)(idOrden == null ? 0 : idOrden);
                            qc.KM = int.Parse(Session["KM"].ToString());
                            if (item.qc.Evaluar == true)
                            {
                                lstEvaluacion = new List<clsEvaluacion>();
                               
                                var consultEval = (from qce in entity.quickcheckevalactividads
                                                   join cce in entity.calidadconceptoevaluacions on qce.ConceptoEvaluacion equals cce.ConceptoEvaluacion into ce
                                                   from cce in ce.DefaultIfEmpty()
                                                   where qce.Evaluacion == cce.Evaluacion
                                                   && qce.IDInterno == qc.IDInterno
                                                   && qce.ID == idOrden
                                                   select new { qce, cce.Orden }).ToList();

                                foreach(var item2 in consultEval)
                                {
                                    var eval = new clsEvaluacion();
                                    eval.ConceptoEvaluacion = item2.qce.ConceptoEvaluacion;
                                    eval.Evaluacion = item2.qce.Evaluacion;
                                    eval.Id = item2.Orden;
                                    eval.IdInterno = item2.qce.IDInterno;
                                    eval.Unidad = item2.qce.Unidad;
                                    eval.Valor = item2.qce.Valor == null ? 0 :(decimal)item2.qce.Valor;
                                    lstEvaluacion.Add(eval);
                                }
                                qc.Evaluacion = lstEvaluacion;
                            
                            }
                            lstQC.Add(qc);
                        }
                        return View(lstQC);
                    }
                    else
                    {
                        Warning("No se encontro lista de quick checks para la orden dada. Fvaor de contactar al administrador");
                        RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden });
                    }
                }
                else
                {
                    RedirectToAction("Index", "Seguridad");
                }
            }catch (Exception e)
            {
                Warning("Error: " + e.Message);
                RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden });
            }

            return View();
        }

        [HttpPost]
        public ActionResult GuardaItemQC(int IdOrden,int IDInterno, string comentarios, string refacReq)
        {
            Events events =new  Events();

            try
            {
                if(Session["Usuario"] != null)
                {
                   
                    manttoquickcheck updateItem = (from qc in entity.manttoquickchecks
                                      where qc.IDInternoI == IDInterno
                                      && qc.ID == IdOrden
                                      select qc).FirstOrDefault();

                    updateItem.Comentario = comentarios;
                    updateItem.RefacRequeridas = refacReq;
                    if(comentarios == string.Empty)
                    {
                        updateItem.Rojo = false;
                        updateItem.Verde = true;
                    }
                    else
                    {
                        updateItem.Rojo = true;
                        updateItem.Verde = false;

                    }
                   
                        entity.SaveChanges();


                        events.Msg = "Informacion generada";
                        events.idMsg = "success";
                        return Json(events, JsonRequestBehavior.AllowGet);
                   
                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch(Exception e)
            {
                events.Msg = e.Message;
                events.idMsg = "error";
                return Json(events, JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction ("OpcionesMenu","SDM");
        }

        public ActionResult GuardaEval(int IDInterno, int IdOrden, string Valor, string Evaluacion, string Concepto)
            {
            Events events = new Events();
            bool isEmpty = false;
            try
            {
                if (Session["Usuario"] != null)
                {
                   if(Valor == string.Empty)
                    {
                        Valor = "0";
                        isEmpty = true;
                    }
                    decimal val = decimal.Parse(Valor);

                    quickcheckevalactividad updateEval = (from qce in entity.quickcheckevalactividads
                                                          where qce.IDInterno == IDInterno
                                                          && qce.ID == IdOrden
                                                          && qce.Evaluacion == Evaluacion
                                                          && qce.ConceptoEvaluacion == Concepto
                                                   select qce).FirstOrDefault();

                    updateEval.Valor = val;
                   
                    entity.SaveChanges();

                    if (isEmpty)
                    {
                        Valor = "";
                    }
                    if (Valor != string.Empty && Valor != "0.00" && Valor != "0.0" && Valor != "0")
                        {
                            events.Msg = "Informacion generada";
                            events.idMsg = "success";
                        }
                        else
                        {
                            events.Msg = "Informacion generada. Con errores";
                            events.idMsg = "warning";
                        }
                          

                    return Json(events, JsonRequestBehavior.AllowGet);
                    }
                   

                
            }
            catch (Exception e)
            {
                events.Msg = e.Message;
                events.idMsg = "error";
                return Json(events, JsonRequestBehavior.AllowGet);
            }
            return Json(events, JsonRequestBehavior.AllowGet);
         
        }

        public ActionResult BuscaQC(int? idOrden, string serieU)
        {
            List<clsQuickCheck> lstQC = new List<clsQuickCheck>();

            try
            {
                if(Session["Usuario"] != null)
                {
                    var objCheckLst = (from qc in entity.manttoquickchecks
                                       join cqc in entity.camsolquickchecks on qc.IDInternoI equals cqc.IDInterno into cs
                                       from cqc in cs.DefaultIfEmpty()
                                       where qc.ID == idOrden
                                       select new { qc, cqc.ItemARevisar, cqc.Sistemas, cqc.Prioritario }).ToList();

                    if (objCheckLst != null && objCheckLst.Count > 0)
                    {
                        foreach(var item in objCheckLst)
                        {
                            clsQuickCheck objQC = new clsQuickCheck();
                            objQC.IDInterno = item.qc.IDInternoI;
                            objQC.IDUnidad = serieU;
                            objQC.ItemARevisar = item.ItemARevisar;
                            objQC.Rojo = item.qc.Rojo == null ? false : (bool)item.qc.Rojo;
                            objQC.Verde = item.qc.Verde == null ? false : (bool)item.qc.Verde;
                            objQC.Comentarios = item.qc.Comentario;
                            objQC.Refacciones = item.qc.RefacRequeridas;
                            objQC.IDOrden = item.qc.ID;
                            objQC.KM = int.Parse(Session["KM"].ToString());
                            objQC.Eval = item.qc.Evaluar == null ? false : (bool)item.qc.Evaluar;
                            if (item.qc.Evaluar == true)
                            {

                                var lstEvaluacion = new List<clsEvaluacion>();

                                var consultEval = (from qce in entity.quickcheckevalactividads
                                                   join cce in entity.calidadconceptoevaluacions on qce.ConceptoEvaluacion equals cce.ConceptoEvaluacion into ce
                                                   from cce in ce.DefaultIfEmpty()
                                                   where qce.Evaluacion == cce.Evaluacion
                                                   && qce.IDInterno == objQC.IDInterno
                                                   && qce.ID == idOrden
                                                   select new { qce, cce.Orden }).ToList();

                                foreach (var item2 in consultEval)
                                {
                                    var eval = new clsEvaluacion();
                                    eval.ConceptoEvaluacion = item2.qce.ConceptoEvaluacion;
                                    eval.Evaluacion = item2.qce.Evaluacion;
                                    eval.Id = item2.Orden;
                                    eval.Unidad = item2.qce.Unidad;
                                    eval.Valor = item2.qce.Valor == null ? 0 : (decimal)item2.qce.Valor;
                                    lstEvaluacion.Add(eval);
                                }
                                objQC.Evaluacion = lstEvaluacion;

                            }
                            lstQC.Add(objQC);
                        }
                      
                    }
                    else
                    {
                        Warning("No se encontro lista de quick checks para la orden dada. Favor de contactar al administrador");
                        RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden });
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }

            }catch (Exception e)
            {
                Warning("Error" + e.Message);
                RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden });
            }
            return View(lstQC);
        }

        public ActionResult ConsultaRefacciones(int idOrden, string unidad)
        {
            List<clsRefacciones> lstRef = new List<clsRefacciones>();
            try
            {
                /* JJM Solo perfil de súper administrador tiene acceso a este modulo*/
                if (Session["Usuario"] != null)
                {

                    usrs = Session["Usuario"].ToString();
                    var consultRF = (from rf in entity.manttosotrefs
                                       join e in entity.invs on rf.IDMA equals e.ID
                                       join d in entity.invds on e.ID equals d.ID
                                       join a in entity.articuloes on d.Articulo equals a.Articulo1
                                       join c in entity.contactoes on rf.Contacto equals c.Contacto1 into co
                                       from c in co.DefaultIfEmpty()
                                       join qc in entity.camsolquickchecks on rf.IDInternoItem equals qc.IDInterno into qcs
                                       from qc in qcs.DefaultIfEmpty()
                                       join pg in entity.contactoes on rf.ProveedorRFG equals pg.Contacto1 into pgs
                                       from pg in pgs.DefaultIfEmpty()
                                       where rf.TipoAplicacion == "refacciones"
                                       && rf.RenglonIDMA == d.RenglonID
                                       && rf.ID == idOrden
                                       select new { a, d, rf }).ToList();

                    if (consultRF != null && consultRF.Count()> 0)
                    {

                    
                    foreach (var item in consultRF)
                    {
                        clsRefacciones objRefacciones = new clsRefacciones();
                        objRefacciones.Articulo = item.a.Articulo1;
                        objRefacciones.Cantidad = (decimal)item.d.Cantidad;
                        objRefacciones.Descripcion = item.a.Descripcion;
                        objRefacciones.Marca = item.a.Marca;
                        objRefacciones.Linea = item.a.Linea;
                        objRefacciones.Unidad = item.d.Unidad;
                        objRefacciones.IdOrden = idOrden;
                        objRefacciones.IdUnidad = unidad;
                        objRefacciones.KM = int.Parse(Session["KM"].ToString());

                        lstRef.Add(objRefacciones);
                        
                      


                    }
                    }
                    else
                    {
                        clsUnidad objUnidad1 = new clsUnidad();
                        objUnidad1.idUnidad = idOrden;
                        objUnidad1.Serie = unidad;
                        objUnidad1.KM = int.Parse(Session["KM"].ToString());

                        Warning("No existen elementos para mostrar en Refacciones");
                        return RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden, Serie = unidad, KM = int.Parse(Session["KM"].ToString()) });
                   
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch (Exception e)
            {
                Danger("Error: " + e.Message);
                RedirectToAction("Index", "Seguridad");
            }
            return View(lstRef);
        }

        public ActionResult ConsultaMO(int idOrden, string unidad)
        {
            List<clsMO> lstMO = new List<clsMO>();
            try
            {
                /* JJM Solo perfil de súper administrador tiene acceso a este modulo*/
                if (Session["Usuario"] != null)
                {

                    usrs = Session["Usuario"].ToString();

                    var consult1 = from xc in entity.manttodtareafhists
                                   group new { xc.ID, xc.RenglonID } by xc into grp1
                                   orderby grp1.Key.IDInterno descending
                                   select grp1.Key;


                    var consultMO = (from d in entity.manttods
                                    join a in entity.articuloes on d.ArticuloSE equals a.Articulo1 into ar
                                    from a in ar.DefaultIfEmpty()
                                    join p in entity.manttoaplicas on d.AplicaID equals p.AplicaID into ma
                                    from p in ma.DefaultIfEmpty()
                                    join dt in entity.manttotareafechaconcluirs on new { X1 = d.ID, X2= d.RenglonID }  equals new  {X1 = dt.IDD , X2= dt.RenglonIDD} into tr
                                    from dt in tr.DefaultIfEmpty()
                                    join cgr in entity.cuadrillagrupoes on d.Cuadrilla equals cgr.Cuadrilla into cua
                                    from cgr in cua.DefaultIfEmpty()
                                    join c in entity.contactoes on d.Agente equals c.Contacto1 into co
                                    from c in co.DefaultIfEmpty()
                                    join mt in entity.manttocattareas on d.Tarea equals mt.Tarea into ta
                                    from mt in ta.DefaultIfEmpty()
                                    join qc in entity.camsolquickchecks on d.IDInternoItem equals qc.IDInterno into cqs
                                    from qc in cqs.DefaultIfEmpty()
                                    join co1 in entity.manttodtareacods on d.Tarea equals co1.Tarea into tc
                                    from co1 in tc.DefaultIfEmpty()
                                    join pg in entity.contactoes on d.ProveedorGD equals pg.Contacto1 into pgs
                                    from pg in pgs.DefaultIfEmpty()
                                    join mft in consult1 on  new { d.ID, d.RenglonID }  equals new { mft.ID, mft.RenglonID }  into th
                                    from mft in th.DefaultIfEmpty()
                                    where d.ID == idOrden
                                    select new { co1, dt, a, d }).ToList();

                    if (consultMO != null && consultMO.Count() > 0)
                    {



                        foreach (var item in consultMO)
                    {
                        clsMO objMO = new clsMO();
                        objMO.MO = item.d.ServicioD;
                        objMO.Codigo = item.co1.CodigoTarea;
                        objMO.TiempoEstimado = item.d.Duracion;
                        objMO.TipoUnidadAliado = item.d.TipoUnidadAliado;
                        objMO.IdOrden = idOrden;
                        objMO.IdUnidad = unidad;
                        objMO.KM = int.Parse(Session["KM"].ToString());

                        lstMO.Add(objMO);




                    }
                    }
                    else
                    {
                        clsUnidad objUnidad1 = new clsUnidad();
                        objUnidad1.idUnidad = idOrden;
                        objUnidad1.Serie = unidad;
                        objUnidad1.KM = int.Parse(Session["KM"].ToString());

                        Warning("No existen elementos para mostrar en MO");
                        return RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden, Serie = unidad, KM = int.Parse(Session["KM"].ToString()) });
                   
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch (Exception e)
            {
                Danger("Error: " + e.Message);
                RedirectToAction("Index", "Seguridad");
            }
            return View(lstMO);
        }

        public ActionResult ConsultaTOTS(int idOrden, string unidad)
        {
            List<clsTOTS> lsTots = new List<clsTOTS>();
            try
            {
                /* JJM Solo perfil de súper administrador tiene acceso a este modulo*/
                if (Session["Usuario"] != null)
                {

                    usrs = Session["Usuario"].ToString();
                    var consultTOTS = (from rfs in entity.manttosotrefs
                                     join e in entity.cgs on rfs.IDMA equals e.ID
                                     join d in entity.cgds on e.ID equals d.ID
                                     join a in entity.articuloes on d.Articulo equals a.Articulo1
                                     join c in entity.contactoes on rfs.Contacto equals c.Contacto1 into co
                                     from c in co.DefaultIfEmpty()
                                     join qc in entity.camsolquickchecks on rfs.IDInternoItem equals qc.IDInterno into qcs
                                     from qc in qcs.DefaultIfEmpty()
                                     join pg in entity.contactoes on rfs.ProveedorRFG equals pg.Contacto1 into pgs
                                     from pg in pgs.DefaultIfEmpty()
                                     where rfs.TipoAplicacion == "solicotrotaller"
                                     && rfs.RenglonIDMA == d.RenglonID
                                     && rfs.ID == idOrden
                                     select new { a, d, rfs, c }).ToList();
                    

                    if (consultTOTS != null && consultTOTS.Count() > 0)
                    {


                        foreach (var item in consultTOTS)
                        {
                            clsTOTS objTOTS = new clsTOTS();
                            objTOTS.Articulo = item.a.Articulo1;
                            objTOTS.Descripcion = item.a.Descripcion2 == null ? "(Sin descripción)" : item.a.Descripcion2;
                            objTOTS.Proovedor = item.rfs.Contacto;
                            objTOTS.Nombre = item.c.Nombre + " " + item.c.ApellidoPaterno + " "  + item.c.ApellidoMaterno;
                            objTOTS.IdOrden = idOrden;
                            objTOTS.IdUnidad = unidad;
                            objTOTS.KM = int.Parse(Session["KM"].ToString());

                            lsTots.Add(objTOTS);




                        }
                    }
                    else
                    {
                        clsUnidad objUnidad1 = new clsUnidad();
                        objUnidad1.idUnidad = idOrden;
                        objUnidad1.Serie = unidad;
                        objUnidad1.KM = int.Parse(Session["KM"].ToString());

                        Warning("No existen elementos para mostrar en TOTS");
                        return RedirectToAction("OpcionesUnidad", "SDM", new { idUnidad = idOrden, Serie = unidad, KM = int.Parse(Session["KM"].ToString()) });

                    }

                }
                else
                {
                    return RedirectToAction("Index", "Seguridad");
                }
            }
            catch (Exception e)
            {
                Danger("Error: " + e.Message);
                RedirectToAction("Index", "Seguridad");
            }
            return View(lsTots);
        }

        public ActionResult GeneraOrdenServicio()
        {
            var objOS = new clsOrdenServicio();
            try
            {
                if (Session["Usuario"] != null)
                {
                   

                    var consultConcepto = entity.Database.SqlQuery<clsMsgSP2>("call spConceptoMov({0}, {1})", new object[] { "MANTTO", "Solicit Serv MODELO" }).ToList();
                    objOS.CatConcepto = consultConcepto.Select(s => new System.Web.Mvc.SelectListItem { Value = s.Concepto, Text = s.Concepto });




                    //Evaluamos si existe el usuario en la base

                    var consultTMantenimiento = from m in entity.manttotipoes
                                                where m.EsPaquete == false
                                                select new System.Web.Mvc.SelectListItem { Value = m.MantenimientoTipo, Text = m.MantenimientoTipo };


                    objOS.CatTipoMantenimiento = consultTMantenimiento;

                    objOS.CatServicio = new List<System.Web.Mvc.SelectListItem>() { new System.Web.Mvc.SelectListItem { Value = "", Text = "" } };
                }
            }
            catch (Exception e)
            {
                Danger("Error" + e.Message);
            }

            return View(objOS);
        }


        public ActionResult FillTipoServicioOS(string tMantenimiento)
        {
            var consultTServicio = (from s in entity.manttotipods
                                   where s.MantenimientoTipo == tMantenimiento
                                           select new System.Web.Mvc.SelectListItem { Value = s.Servicio, Text = s.Servicio }).ToList();

            return Json(consultTServicio, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GuardaOrdenServicio(clsOrdenServicio objOrdenServ)
        {
            var objOS = new clsOrdenServicio();
            try
            {
                if (Session["Usuario"] != null)
                {
                    var suc = int.Parse(Session["IdSuc"].ToString());
                    var usr = Session["Usuario"].ToString();
                    if (objOrdenServ != null)
                    {
                     
                       


                        var param1 = new MySqlParameter("vg_Empresa", 1) { Direction = ParameterDirection.Input };
                        param1.Direction = System.Data.ParameterDirection.Input;
                        var param2 = new MySqlParameter("vg_Modulo", "MANTTO") { Direction = ParameterDirection.Input };
                        param2.Direction = System.Data.ParameterDirection.Input;
                        var param3 = new MySqlParameter("vg_Sucursal", suc) { Direction = ParameterDirection.Input };
                        param3.Direction = System.Data.ParameterDirection.Input;
                        var param4 = new MySqlParameter("vg_TipoMantto", objOrdenServ.CatSelectTipoMantenimiento) { Direction = ParameterDirection.Input };
                        param4.Direction = System.Data.ParameterDirection.Input;
                        var param5 = new MySqlParameter("vg_Servicio", objOrdenServ.CatSelectServicio) { Direction = ParameterDirection.Input };
                        param5.Direction = System.Data.ParameterDirection.Input;
                        var param6 = new MySqlParameter("vg_EquipoVin", objOrdenServ.unidad) { Direction = ParameterDirection.Input };
                        param6.Direction = System.Data.ParameterDirection.Input;
                        var param7 = new MySqlParameter("vg_Usuario", usr) { Direction = ParameterDirection.Input };
                        param7.Direction = System.Data.ParameterDirection.Input;
                        var param8 = new MySqlParameter("vg_Concepto", objOrdenServ.CatSelectConcpeto) { Direction = ParameterDirection.Input };
                        param8.Direction = System.Data.ParameterDirection.Input;
                        var param9 = new MySqlParameter("vg_SinTransaccion", 0) { Direction = ParameterDirection.Input };
                        param9.Direction = System.Data.ParameterDirection.Input;
                        var OK = new MySqlParameter("vg_OK", MySqlDbType.VarChar){ Direction = ParameterDirection.Output };
                        var msg = new MySqlParameter("vg_OkMensaje", MySqlDbType.VarChar) { Direction = ParameterDirection.Output };
                        var iDOS = new MySqlParameter("vg_IDOS", MySqlDbType.Int32) { Direction = ParameterDirection.Output };
        
                        MySqlParameter[] lstPatram = new MySqlParameter[] { param1, param2, param3, param4, param5, param6, param7, param8, param9, OK, msg, iDOS };

                        var selectSuc = entity.Database.SqlQuery<string>($"Call spManttoGeneraPMOS({0},{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", lstPatram);

                        
                         
                        Success("La orden fue guardada satisfactoriamente " + OK.Value+ selectSuc.FirstOrDefault());
                    }

                }
            }
            catch (Exception e)
            {
                Danger("Error" + e.Message);


            }

            return  RedirectToAction("GeneraOrdenServicio",objOS);
        }

        public ActionResult ModificaPM(int idInterno, int idOrden, string unidad)
        {
            clsQuickCheck objQC = new clsQuickCheck();
            List<clsEvaluacion> lstEvalua = new List<clsEvaluacion>();
            try
            {
                if (Session["Usuario"] != null)
                {
                    var consultQC = (from qc in entity.manttoquickchecks
                                                  join cqc in entity.camsolquickchecks on qc.IDInternoI equals cqc.IDInterno into cs
                                                  from cqc in cs.DefaultIfEmpty()
                                                  where qc.IDInternoI == idInterno
                                                   && qc.ID == idOrden
                                                   select new { qc, cqc.ItemARevisar }).FirstOrDefault();

                    objQC.IDUnidad = unidad;
                    objQC.IDOrden = idOrden;
                    objQC.IDInterno = idInterno;
                    objQC.Eval = consultQC.qc.Evaluar == null? false : true;
                    objQC.Comentarios = consultQC.qc.Comentario;
                    objQC.Refacciones = consultQC.qc.RefacRequeridas;
                    objQC.Verde = (bool)consultQC.qc.Verde;
                    objQC.VerdeRojo = null;
                    objQC.Rojo = (bool)consultQC.qc.Rojo;
                    objQC.ItemARevisar = consultQC.ItemARevisar;
                        

                    if (objQC.Eval == true)
                    {
                    
                               var consultEval = (from qce in entity.quickcheckevalactividads
                                                   join cce in entity.calidadconceptoevaluacions on qce.ConceptoEvaluacion equals cce.ConceptoEvaluacion into ce
                                                   from cce in ce.DefaultIfEmpty()
                                                   where qce.Evaluacion == cce.Evaluacion
                                                   && qce.IDInterno == objQC.IDInterno
                                                   && qce.ID == idOrden
                                                   select new { qce, cce.Orden }).ToList();

                                foreach (var item2 in consultEval)
                                {
                                    var eval = new clsEvaluacion();
                                    eval.ConceptoEvaluacion = item2.qce.ConceptoEvaluacion;
                                    eval.Evaluacion = item2.qce.Evaluacion;
                                    eval.Id = item2.Orden;
                                    eval.IdInterno = item2.qce.IDInterno;
                                    eval.Unidad = item2.qce.Unidad;
                                    eval.Valor = item2.qce.Valor == null ? 0 : (decimal)item2.qce.Valor;
                                    lstEvalua.Add(eval);
                                }
                                objQC.Evaluacion = lstEvalua;

                          
                         
                    }


                    
           
                }
            }catch( Exception e)
            {
                Danger("error" + e.Message);
                return RedirectToAction("BuscaQC", "SDM", new { idOrden = objQC.IDOrden, serieU = objQC.IDUnidad }) ;
            }

            return View(objQC);
        }

        public ActionResult MuestraCotizacion(int idOrden)
        {
            try
            {

            }catch(Exception e)
            {

            }
            return View();
        }
    }

    

    
}