using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetSecurity.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        // GET: Secret
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        public ContentResult Secret()
        {
            return Content("Secret Information Here");
        }

        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Public Information Here");
        }
    }
}