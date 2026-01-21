using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult PrimeraPagina() 
        {
            return View();
        }
    }
}
