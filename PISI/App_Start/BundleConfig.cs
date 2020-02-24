using System.Web;
using System.Web.Optimization;

namespace PISI
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

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Content/js", "~/Content/js/*.js"));
            bundles.Add(new ScriptBundle("~/Content/js/vendor").Include(
                        "~/Content/js/vendor", "~/Content/js/vendor/*.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css/css").Include(
                      "~/Content/css", "~/Content/css/*.css"));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include(
                     "~/Content/css/bootstrap", "~/Content/css/bootstrap/*.css"));

            bundles.Add(new StyleBundle("~/Content/css/theme").Include(
                     "~/Content/css/theme", "~/Content/css/theme/*.css"));

            bundles.Add(new StyleBundle("~/Content/scss").Include(
                    "~/Content/scss", "~/Content/scss/*.scss"));

            bundles.Add(new StyleBundle("~/Content/scss/bootstrap").Include(
                    "~/Content/scss/bootstrap", "~/Content/scss/bootstrap/*.scss"));

            bundles.Add(new StyleBundle("~/Content/scss/bootstrap/mixins").Include(
                    "~/Content/scss/bootstrap/mixins", "~/Content/scss/bootstrap/mixins/*.scss"));

            bundles.Add(new StyleBundle("~/Content/scss/bootstrap/utilities").Include(
                    "~/Content/scss/bootstrap/utilities", "~/Content/scss/bootstrap/utilities/*.scss"));

            bundles.Add(new StyleBundle("~/Content/scss/theme").Include(
                   "~/Content/scss/theme", "~/Content/scss/theme/*.scss"));
        }
    }
}
