using System.Web.Optimization;

namespace testing
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Scripts/materialize.js",
                      "~/Scripts/common.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css/material").Include(
                      "~/Content/css/materialize.css",
                      "~/Content/css/custom-styles.css"));
        }
    }
}