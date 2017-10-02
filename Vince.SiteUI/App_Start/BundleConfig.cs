using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Vince.SiteUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jQuery", "https://code.jquery.com/jquery-3.2.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapcdn","https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new StyleBundle("~/bundles/icons",
            "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/Reveal.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",
                      "~/Content/ErrorStyles.css",
                      "~/Content/Icons.css",
                      "~/Content/HomeStyle.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}