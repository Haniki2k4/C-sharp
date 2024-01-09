using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //1 hàm -> 1 view
        //1 controller -> nhiều action
        // GET: Home
        public ActionResult Index()
        {
            return View();

            //chuyển hướng chủ động trên server qua action khác, cùng controller
            //return RedirectToAction("Login");

            //chuyển hướng chủ động trên server qua action khác, khác controller
            //return RedirectToAction("ListNews", "TinTuc");

            //chuyển hướng chủ động trên server qua action khác, khác controller
            //return RedirectToAction("ListNews", "TinTuc");

            //chuyển hướng theo link
            //return Redirect("https://google.com");

            //chuyển hướng = route
            //return RedirectToRoute("Default");
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        //chuyển hướng trên server
        public ActionResult Login()
        {
            return View();
        }
    }
}