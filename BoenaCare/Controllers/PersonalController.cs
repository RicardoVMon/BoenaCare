using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoenaCare.Controllers
{
    public class PersonalController : Controller
    {
        
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
    }
}