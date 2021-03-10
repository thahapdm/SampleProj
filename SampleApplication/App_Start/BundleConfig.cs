using System.Web;
using System.Web.Optimization;

namespace SampleApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            //"~/Content/bower_components/jquery/dist/jquery.min.js",
            //"~/Content/bower_components/jquery/dist/jquery-migrate-1.2.1.js",

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/Others").Include(
                     
                         "~/Content/bower_components/jquery/dist/jquery.alerts.js",
                           "~/Content/bower_components/datatables.net/js/jquery.dataTables.min.js",
                             "~/Content/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js",
                               "~/Content/bower_components/fastclick/lib/fastclick.js",
                                 "~/Content/bower_components/fastclick/lib/fastclick.js",
                                   "~/Content/js/adminlte.min.js",
                                    "~/Content/js/demo.js",
                                     "~/Content/bower_components/jquery/dist/waitingDialog.js"

                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                     "~/Content/jquery.alerts.css",
                     "~/Content/bower_components/font-awesome/css/font-awesome.min.css",
                     "~/Content/bower_components/Ionicons/css/ionicons.min.css",
                     "~/Content/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css",
                     "~/Content/css/skins/_all-skins.min.css",
                     "~/Content/css/AdminLTE.min.css"

                     )
                      );
        }
    }
}
