using System.Web;
using System.Web.Mvc;

namespace Ember_Contact_Management_WebAPI {
    public class FilterConfig {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters ) {
            filters.Add( new HandleErrorAttribute() );
        }
    }
}