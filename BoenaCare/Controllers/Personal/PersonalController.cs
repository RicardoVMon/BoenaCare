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

        // Funcionalidad: listado de Pacientes
        public ActionResult ListadoPacientes()
        {
            return View();
        }

        public ActionResult AgregarPaciente()
        {
            return View();
        }

        // Funcionalidad: Informacion de paciente
        public ActionResult InformacionPaciente()
        {
            return View();
        }

        //Funcionalidad: Agregar archivos pacientes
        public ActionResult AgregarArchivo()
        {
            return View();
        }

        
    }
}