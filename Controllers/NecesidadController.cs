using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_PW3.Controllers
{
    public class NecesidadController : Controller
    {
        // GET: Necesidad
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Donar()
        {
            return View();
        }
        public ActionResult ListaDonaciones()
        {
            return View();
        }

        public ActionResult Necesidad()
        {
            return View();
        }
    }
}