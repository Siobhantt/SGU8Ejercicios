using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using U8.Models;

namespace U8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //El controlador de la vista index
        public IActionResult Index()
        {
            return View();
        }
        //El controlador de la vista saludo, que recibe el nombre

        public IActionResult Saludo(String nombre)
        {
            //la viewbag que mostrará el nombre en la vista saludo
            ViewBag.Nombre = nombre;
            return View("Saludo");
        }

       

    }
}