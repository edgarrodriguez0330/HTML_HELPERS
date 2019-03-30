using HTML_HELPERS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_HELPERS.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ClienteGenero = new SelectList(new[] {
                "Masculino", "Femenino"
            });
            return View();
        }

        public ActionResult Index(Cliente cliente)
        {
            return View(cliente);
        }

        public ActionResult Index2(Cliente cliente)
        {
            return View(cliente);
        }

        [HttpPost]
        public ActionResult ProcesarFormulario(Cliente estudi)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("MostarDatos", estudi);
            }
            else
            {
                return View("Formulario");
            }
        }

        public ActionResult MostrarDatos(Cliente obj)
        {
            return View(obj);

            //Estudiante datos = new Estudiante();

            //datos.Nombre = Request.Form["nombre"].ToString();
            //datos.Edad = int.Parse(Request.Form["edad"]);
            //datos.Carrera = Request.Form["carrera"].ToString();
            //datos.Cuatrimestre = int.Parse(Request.Form["cuatrimestre"]);


        }

        


    }
}