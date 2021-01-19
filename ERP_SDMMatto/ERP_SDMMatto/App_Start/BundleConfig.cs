using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Windows.Forms;

namespace ERP_SDMMatto.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            int alto = Screen.PrimaryScreen.Bounds.Height; //Obtiene el alto de la pantalla principal en pixeles.
            int ancho = Screen.PrimaryScreen.Bounds.Width; //Obtiene el ancho de la pantalla principal en pixeles.

            System.Web.Optimization.BundleTable.EnableOptimizations = false;

            if (Screen.PrimaryScreen.Bounds.Width < 1023)
                bundles.Add(new StyleBundle("~/Content/ResolucionPantalla").Include("~/Content/res1.css"));
            else if (Screen.PrimaryScreen.Bounds.Width >= 1024)
                bundles.Add(new StyleBundle("~/Content/ResolucionPantalla").Include("~/Content/res2.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/jquery-ui-{version}.custom.js",
                          "~/Scripts/jquery-ui-{version}.js",
                         "~/Scripts/miscelaneo.js",
                          "~/Scripts/moment.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                       "~/Scripts/respond.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/ie10-viewport-bug-workaround.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/stepsForms.css",
        
                    "~/Content/apariencia.css"
                   
                 ));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
        }
    }
}