using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class PacienteController : Controller
    {
        [HttpGet]
        public ActionResult Listado()
        {
            return View();
        }
        [HttpGet]
        public ActionResult FichaClinica()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Tratamientos()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Archivos()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AsistenteIA()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AgregarPaciente()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AgregarArchivo()
        {
            return View();
        }

        public ActionResult EditarPaciente()
        {
            return View();
        }
        
    }
}