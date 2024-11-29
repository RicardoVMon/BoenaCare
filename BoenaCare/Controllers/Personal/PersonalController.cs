using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class PersonalController : Controller
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

        // Funcionalidad: Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        // Funcionalidad: Pacientes
        public ActionResult Listado()
        {
            return View();
        }

        // Funcionalidad: Ficha clinica
        public ActionResult InformacionPaciente()
        {
            return View();
        }

        // Funcionalidad: Archivos 
        public ActionResult Archivos()
        {
            return View();
        }
    }
}