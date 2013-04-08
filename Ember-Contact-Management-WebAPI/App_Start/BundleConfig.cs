using System.Web;
using System.Web.Optimization;

namespace Ember_Contact_Management_WebAPI {
    public class BundleConfig {        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles( BundleCollection bundles ) {
            bundles.Add( new ScriptBundle( "~/bundles/jquery" ).Include(
                        "~/Scripts/jquery-{version}.js" ) );

            bundles.Add( new ScriptBundle( "~/bundles/jqueryui" ).Include(
                        "~/Scripts/jquery-ui-{version}.js" ) );

            bundles.Add( new Bundle( "~/bundles/jqueryval", new JsMinify() ).Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*" ) );

            bundles.Add( new Bundle( "~/bundles/basejs", new JsMinify() ).Include(
                "~/scripts/jquery-{version}.js",
                "~/scripts/bootstrap.js",
                "~/scripts/html5shiv.js"
            ) );

            bundles.Add( new StyleBundle( "~/content/tbs" ).Include(
                "~/content/bootstrap.css"
            ) );

            bundles.Add( new Bundle( "~/content/tbs-r", new CssMinify() ).Include(
                "~/content/bootstrap-responsive.css"
            ) );

            bundles.Add( new Bundle( "~/content/site", new CssMinify() ).Include(
               "~/content/_site.css"
           ) );

            bundles.Add( new Bundle( "~/bundles/ember", new JsMinify() ).Include(
                "~/Scripts/handlebars.js",
                "~/Scripts/ember-1.0.0-rc.2.js",
                "~/Scripts/ember-data.js",
                "~/Scripts/app/webapi_serializer.js",
                "~/Scripts/app/webapi_adapter.js"
            ) );

            bundles.Add( new ScriptBundle( "~/bundles/ajaxlogin" ).Include(
                "~/Scripts/app/ajaxlogin.js" ) );

            bundles.Add( new ScriptBundle( "~/bundles/app" ).Include(
                "~/Scripts/app/app.js",
                "~/Scripts/app/setup/*.js" )
                .IncludeDirectory( "~/Scripts/app/routes", "*.js" )
                .IncludeDirectory( "~/Scripts/app/models", "*.js" )
                .IncludeDirectory( "~/Scripts/app/views", "*.js" )
                .IncludeDirectory( "~/Scripts/app/controllers", "*.js" ) );

            bundles.Add( new ScriptBundle( "~/bundles/modernizr" ).Include(
                        "~/Scripts/modernizr-*" ) );

            bundles.Add( new StyleBundle( "~/Content/css" ).Include(
                "~/Content/Site.css" ) );

            bundles.Add( new StyleBundle( "~/Content/themes/base/css" ).Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css" ) );
        }
    }
}