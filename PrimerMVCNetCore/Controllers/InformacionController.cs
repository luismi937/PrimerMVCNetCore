using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControladorVista() 
        {
            //vamos a enviar informacion simple a la vista
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 25;
            ViewBag.DiaSemana = "jueves";



            return View();
        }
        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@gmail.com";
            persona.Edad = 88;
            return View(persona);
        }
        public IActionResult VistaControllerGet(string saludo, int? year)
            //la interrogacion es como el system.Nullable es decir es una propiedad que admite 
            //valores nulos
        {
            //para comprobar que hemos recibido los datos mediante un actionLink  devolvemos un mensaje para 
            //dibujarlo
            if (saludo != null)
            {
                ViewData["mensaje"] = saludo + "en el año" + year;
            }
            else
            {
                ViewData["MENSAJE"] = "Aqui no tenemos ni tiempo";
            }

                return View();
        }
        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControllerPost(Persona perosna
            ,string aficiones)
        {
            ViewData["MENSAJE"] = "Nombre:" + persona.Nombre + ", Email" + persona.Email + ", Edad:" + persona.Edad+ ", Aficiones" +aficiones;
            return View();
        }
    }
}
