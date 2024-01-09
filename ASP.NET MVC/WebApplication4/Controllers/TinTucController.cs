using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult ListNews()
        {
            return View();
        }
        public ActionResult ReadNews()
        {
            return View();
        }

    }
}