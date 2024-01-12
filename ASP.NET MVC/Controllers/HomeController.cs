using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstExc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TrangChu()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        //truyền sang view của controller khác
        public ActionResult TinTuc()
        {
            return RedirectToAction("ListNews","TinTuc");
        }
    }
}