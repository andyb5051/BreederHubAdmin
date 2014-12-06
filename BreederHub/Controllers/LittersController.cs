using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BreederHub.Controllers.Dogs
{
    public class LittersController : Controller
    {
        //
        // GET: /Litters/

        public ActionResult Index()
        {
            return View();
        }

    }
}
