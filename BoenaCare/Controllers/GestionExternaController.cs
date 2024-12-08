using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class GestionExternaController : Controller
    {
        // GET: GestionExterna
        public ActionResult Formulario()
        {
            return View();
        }
        // GET: GestionExterna
        public ActionResult TablaCierres()
        {
            return View();
        }
    }
}