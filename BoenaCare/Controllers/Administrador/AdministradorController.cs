using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class AdministradorController : Controller
    {

        // Funcionalidad: Perfil
        public ActionResult Perfil()
        {
            return View();
        }
        public ActionResult ConfigurarPerfil()
        {
            return View();
        }

        // Funcionalidad: Personal
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult AgregarPersonal()
        {
            return View();
        }

        public ActionResult InformacionPersonal()
        {
            return View();
        }

        // Funcionalidad: Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}