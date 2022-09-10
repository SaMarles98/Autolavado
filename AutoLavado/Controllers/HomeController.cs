using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoLavado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        { 

            return View("About");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult LavadoEspecial()
        {
            return View("Lavado-especial");
        }

        public ActionResult LavadoChasis()
        {
            return View("Lavado-chasis");
        }

        public ActionResult LavadoTapiceriaDesmontado()
        {
            return View("Lavado-tapiceria");
        }

        public ActionResult LavadoTapiceriaSencilla()
        {
            return View("Lavado-tapiceriasencillo");
        }

        public ActionResult LavadoInterior()
        {
            return View("Lavado-interior");
        }

        public ActionResult LimpiezaMotor()
        {
            return View("Limpieza-motor");
        }

        public ActionResult Polichado3M()
        {
            return View("Polichad-3m");
        }

        public ActionResult Americano()
        {
            return View("Polichado-americano");
        }

        public ActionResult Registrar()
        {
            return View("Registro");
        }

        public ActionResult IniciarSesion()
        {
            return View("Iniciar-sesion");
        }

        public ActionResult OlvidarContraseña()
        {
            return View("cambio-contraseña");
        }

         public ActionResult CambiarContraseña()
        {
            return View("Restablecer-contraseña");
        }

          public ActionResult Usuario()
        {
            return View("Usuario");
        }

    }
}