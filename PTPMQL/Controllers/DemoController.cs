using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class DemoController : Controller
    {
        giaiPT ketthuc = new giaiPT();
        // GET: Demo
        public ActionResult giai()
        {
            return View();
        }
        [HttpPost]
        public ActionResult giai(string soA, string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double soX = ketthuc.giaiPTbac1(so1, so2);
            ViewBag.x = soX;
            return View();
        }
    }
}
//ABC