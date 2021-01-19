using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using EmailNotifications.ModelTemplates;
using System.IO;
using RazorEngine.Templating;


namespace EmailNotifications.SenderMail
{

    public class SenderMailImpl : ISenderMail
    {
        static readonly string TemplateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("CONNECTOR\\", string.Empty), "EmailNotifications\\EmailTemplates");

        public bool EnviarMail(BaseModel baseModel)
        {
            MailMessage mm = new MailMessage();
            SmtpClient client = baseModel.SmptClient;
            mm.IsBodyHtml = true;
            foreach (string temp in baseModel.To)
            {
                mm.To.Add(temp);
            }

            if (baseModel.Cc != null)
                foreach (string temp in baseModel.Cc)
                {
                    mm.CC.Add(temp);
                }

            if (baseModel is RecoveryPasswordModel)
            {

                if (baseModel.Idioma == IdiomaConstants.ESPANIOL)
                {

                    mm.Subject = baseModel.Subject;
                    mm.Body = recoveryPassword((RecoveryPasswordModel)baseModel);
                }
                else
                {

                    mm.Subject = baseModel.Subject;
                    mm.Body = recoveryPassword((RecoveryPasswordModel)baseModel);
                }


            }
            else if (baseModel is SuccessValidationPurchaseOrderModel)
            {
                SuccessValidationPurchaseOrderModel objPO_Model = (SuccessValidationPurchaseOrderModel)baseModel;
                if (objPO_Model.lErrOrdenCompra.Count <= 0)
                {//Sin errores
                    mm.Subject = baseModel.Subject;
                    switch (objPO_Model.Tipo)
                    {
                        case TipoNotificacion.PO_Vendor:
                            successValidationPurchaseOrderVendor(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PO_Buyer:
                            successValidationPurchaseOrder(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.RecepcionAlmacen:
                            successValidationRecepcionAlmacen(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasNuevas:
                            acceptedDeparture(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasModificadas:
                            partidasModificadas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasCanceladas:
                            partidasCanceladas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasCerradas:
                            partidasCerradas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasEnDevolucion:
                            partidasEnDevolucion(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.SoloOrdenesCompra:
                            successValidationPurchaseOrder(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.OCCanceladaProveedor:
                            OrdenCompraCanceladaProveedor(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.OCCerradaProveedor:
                            OrdenCompraCerradaProveedor(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        default:
                            variosMovimientos(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                    }
                }
                else
                {//Hubo errores
                    mm.Subject = baseModel.Subject;

                    switch (objPO_Model.Tipo)
                    {
                        case TipoNotificacion.PartidasNuevas:
                            rejectedDeparture(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.RecepcionAlmacen:
                            successValidationRecepcionAlmacen(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasModificadas:
                            partidasModificadas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasCanceladas:
                            partidasCanceladas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasCerradas:
                            partidasCerradas(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.PartidasEnDevolucion:
                            partidasEnDevolucion(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        case TipoNotificacion.SoloOrdenesCompra:
                            failValidationPurchaseOrder(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                        default:
                            variosMovimientos(objPO_Model);
                            mm.Body = ObtenerHtmlBody(objPO_Model);
                            break;
                    }
                }

            }
            else if (baseModel is DateModel)
            {
                if(baseModel.TipoNotificacion != 7)
                {
                    mm.Subject = baseModel.Subject;
                    mm.Body = dateChangeNotification((DateModel)baseModel);
                }
                else
                {
                    mm.Subject = baseModel.Subject;
                    mm.Body = dateNotification((DateModel)baseModel);
                }
               

            }
            else if (baseModel is ValidarArchivoSaldos)
            {
                mm.Subject = baseModel.Subject;
                mm.Body = ValidaArchivoSaldos((ValidarArchivoSaldos)baseModel);
            }

            client.Send(mm);

            return true;
        }

        private string ObtenerHtmlBody(SuccessValidationPurchaseOrderModel succesValidationPO_Model)
        {
            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(succesValidationPO_Model.sRutaPlantilla), succesValidationPO_Model, null, null);

            return (String)emailHtmlBody;
        }


        /// <summary>
        /// Recuperacion de Password
        /// </summary>
        /// <param name="recoveryPasswordModel"></param>
        /// <returns></returns>
        private string recoveryPassword(RecoveryPasswordModel recoveryPasswordModel)
        {

            var model = recoveryPasswordModel;
            var emailTemplatePath = "";
            if (recoveryPasswordModel.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.RECOVERY_PASWWORD_TEMPLATE_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.RECOVERY_PASWWORD_TEMPLATE_EN_US);
            }

            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(emailTemplatePath), model, null, null);
            return (String)emailHtmlBody;
        }

        /// <summary>
        /// Errores de validacion de Orden de Compra
        /// </summary>
        /// <param name="failValidationPurcheaseOrderModel"></param>
        /// <returns></returns>
        private void failValidationPurchaseOrder(SuccessValidationPurchaseOrderModel failValidationPurcheaseOrderModel)
        {
            var emailTemplatePath = string.Empty;
            if (failValidationPurcheaseOrderModel.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.FAIL_VALIDATION_PURCHASE_ORDER_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.FAIL_VALIDATION_PURCHASE_ORDER_EN_US);
            }

            failValidationPurcheaseOrderModel.sRutaPlantilla = emailTemplatePath;
        }

        /// <summary>
        /// Envia la notificacion de procesamiento correcto al comprador
        /// </summary>
        /// <param name="PO_Model"></param>
        /// <returns></returns>
        private void successValidationPurchaseOrder(SuccessValidationPurchaseOrderModel PO_Model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_Model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.SUCCESS_VALIDATION_PURCHASE_ORDER_BUYER_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.SUCCESS_VALIDATION_PURCHASE_ORDER_BUYER_EN_US);
            }

            PO_Model.sRutaPlantilla = emailTemplatePath;
        }

        /// <summary>
        /// Envia la notificacion de Recepcion en Almacén
        /// </summary>
        /// <param name="PO_model"></param>
        /// <returns></returns>
        private void successValidationRecepcionAlmacen(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.RECEPCION_ALMACEN_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.RECEPCION_ALMACEN_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        /// <summary>
        /// Envia la notificacion de procesamiento correcto al proveedor
        /// </summary>
        /// <param name="succesValidationPurchaseOrderModel"></param>
        /// <returns></returns>
        private void successValidationPurchaseOrderVendor(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.SUCCESS_VALIDATION_PURCHASE_ORDER_VENDOR_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.SUCCESS_VALIDATION_PURCHASE_ORDER_VENDOR_EN_US);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        /// <summary>
        /// Para aceptacion de partidas
        /// </summary>
        /// <param name="PO_model"></param>
        private void acceptedDeparture(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.ACCEPTED_DEPARTURE_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.ACCEPTED_DEPARTURE_EN_US);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        /// <summary>
        /// Para partidas que se modificaron
        /// </summary>
        /// <param name="PO_model"></param>
        private void partidasModificadas(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_MODIFICADAS_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_MODIFICADAS_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private void partidasCanceladas(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = "";
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_CANCELADAS_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_CANCELADAS_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private void OrdenCompraCanceladaProveedor(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.OC_CANCELADA_PROVEEDOR_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.OC_CANCELADA_PROVEEDOR_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private void OrdenCompraCerradaProveedor(SuccessValidationPurchaseOrderModel PO_Model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_Model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.OC_CERRADA_PROVEEDOR_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.OC_CERRADA_PROVEEDOR_ES_MX);
            }

            PO_Model.sRutaPlantilla = emailTemplatePath;
        }

        private void partidasCerradas(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_CERRADAS_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_CERRADAS_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private void partidasEnDevolucion(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_DEVOLUCION_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.PARTIDAS_DEVOLUCION_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private void variosMovimientos(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = string.Empty;
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.VARIOS_MOVIMIENTOS_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, CatalogTemplatesMail.VARIOS_MOVIMIENTOS_ES_MX);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }
        /// <summary>
        /// para partidas Rechazadas
        /// </summary>
        /// <param name="PO_model"></param>
        /// <returns></returns>
        private void rejectedDeparture(SuccessValidationPurchaseOrderModel PO_model)
        {
            var emailTemplatePath = "";
            if (PO_model.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.REJECTED_DEPARTURE_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.REJECTED_DEPARTURE_EN_US);
            }

            PO_model.sRutaPlantilla = emailTemplatePath;
        }

        private string dateChangeNotification(DateModel dateModel)
        {

            var model = dateModel;
            var emailTemplatePath = "";
            if (dateModel.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.DATE_CHANGE_NOTIFICATION_TEMPLATE_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.DATE_CHANGE_NOTIFICATION_TEMPLATE_EN_US);
            }

            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(emailTemplatePath), model, null, null);

            return (String)emailHtmlBody;
        }

        private string dateNotification(DateModel dateModel)
        {

            var model = dateModel;
            var emailTemplatePath = "";
            if (dateModel.Idioma == IdiomaConstants.ESPANIOL)
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.DATE_NOTIFICATION_TEMPLATE_ES_MX);
            }
            else
            {
                emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.DATE_NOTIFICATION_TEMPLATE_EN_US);
            }

            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(emailTemplatePath), model, null, null);

            return (String)emailHtmlBody;
        }
        private string ValidaArchivoSaldos(ValidarArchivoSaldos modelDatos)
        {
            var model = modelDatos;
            var emailTemplatePath = "";
            if (modelDatos.Idioma == IdiomaConstants.ESPANIOL)
            {
                if (model.Error != null)
                {
                    if (model.Error.Count > 0)
                        emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_FAIL_ES_MX);
                    else
                        emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_SUCCESS_ES_MX);
                }
                else
                {
                    emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_SUCCESS_ES_MX);
                }
            }
            else
            {
                if (model.Error != null)
                {
                    if (model.Error.Count > 0)
                        emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_FAIL_EN_US);
                    else
                        emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_SUCCESS_EN_US);
                }
                else
                {
                    emailTemplatePath = Path.Combine(TemplateFolderPath, ModelTemplates.CatalogTemplatesMail.VALIDA_ARCHIVOS_SALDOS_SUCCESS_EN_US);
                }
            }

            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(emailTemplatePath), model, null, null);

            return (String)emailHtmlBody;
        }
    }
}
