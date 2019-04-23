using System.Web;
using System.Web.Optimization;

namespace HRMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/style/adminlte").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/font-awesome.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                        "~/Scripts/Custom/admin.init*",
                        "~/admin-lte2.4.10/js/adminlte.min.js"));

        }
    }
}
