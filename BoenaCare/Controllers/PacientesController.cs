using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class PacientesController : Controller
    {
        [HttpGet]
        public ActionResult Listado()
        {
            return View();
        }

    }
}
