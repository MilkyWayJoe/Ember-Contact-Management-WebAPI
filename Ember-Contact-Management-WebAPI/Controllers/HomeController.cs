using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ember_Contact_Management_WebAPI.Controllers {
    public class HomeController : Controller {
        public ActionResult Index( string returnUrl ) {
            if ( User.Identity.IsAuthenticated ) {
                return View( "App" );
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
    }
}