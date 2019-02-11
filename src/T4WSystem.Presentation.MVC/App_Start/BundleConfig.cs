using System.Web;
using System.Web.Optimization;

namespace T4WSystem.Presentation.MVC
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/RoyalBootstrap/css").Include(
                     "~/Royal/css/bootstrap.css",
                     "~/Royal/vendors/linericon/style.css",
                     "~/Royal/css/font-awesome.min.css",
                     "~/Royal/vendors/owl-carousel/owl.carousel.min.css",
                     "~/Royal/vendors/bootstrap-datepicker/bootstrap-datetimepicker.min.css",
                     "~/Royal/vendors/nice-select/css/nice-select.css",
                     "~/Royal/vendors/owl-carousel/owl.carousel.min.css"));

            bundles.Add(new StyleBundle("~/RoyalMain/css").Include(
                     "~/Royal/css/style.css",
                     "~/Royal/css/responsive.css"));

            bundles.Add(new ScriptBundle("~/Royal/scripts").Include(
                      "~/Royal/js/jquery-3.2.1.min.js",
                      "~/Royal/js/popper.js",
                      "~/Royal/js/bootstrap.min.js",
                      "~/Royal/vendors/owl-carousel/owl.carousel.min.js",
                      "~/Royal/js/jquery.ajaxchimp.min.j",
                      "~/Royal/js/mail-script.js",
                      "~/Royal/vendors/bootstrap-datepicker/bootstrap-datetimepicker.min.js",
                      "~/Royal/vendors/nice-select/js/jquery.nice-select.js",
                      "~/Royal/js/mail-script.js",
                      "~/Royal/js/stellar.js",
                      "~/Royal/vendors/lightbox/simpleLightbox.min.js",
                      "~/Royal/js/custom.js"));

        }
    }
}
