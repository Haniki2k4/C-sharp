using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstExc.Helper;
using FirstExc.Models;

namespace FirstExc.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult ListNews()
        {
            return View();
        }

        public ActionResult AddNews()
        {
            /*int a = 10;
            //truyền vào bằng viewbag
            ViewBag.A = a;*/
            ViewBag.B = new MathHelper().Tinhtong(34,2); //thong qua class mathhelper de gon gang hon
            //return View();

            //c2: truyền qua tham số của view()
            //return View(10);

            //sử dụng cả view và class
            var sv1 = new clssSvien();
            sv1.ID = 1;
            sv1.MaSo = "ss1";
            sv1.Name = "Haaaaaaha";
            sv1.Lop = "khdl";

            ViewBag.sv1 = sv1;

            List<clssSvien> dsSv = new List<clssSvien>();
            dsSv.Add(sv1);
            var sv2 = new clssSvien();
            sv2.ID = 2;
            sv2.MaSo = "ss2";
            sv2.Name = "Heheeeee";
            sv2.Lop = "khdl";
            dsSv.Add(sv2); 


            //return View(sv1);
            return View(dsSv);

        }

    }
}