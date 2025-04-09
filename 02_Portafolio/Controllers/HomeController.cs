using System.Diagnostics;
using _02_Portafolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewBag.Nombre = "Jairo Yesid Yate";
            //ViewBag.Edad = 44;
            //return View("Index", "Jairo Yate Martínez");

            //var persona = new Persona()
            //{
            //    Nombre = "Lina Mora",
            //    Edad = 14
            //};

            //return View(persona);

            var proyectos = ObtenerProyectos();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> listadoProyectos = new List<Proyecto>();

            listadoProyectos.Add(new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce reaizado en ASP.NET Core",
                Link = "https://amazom.com",
                ImagenURL = ""
            });

            listadoProyectos.Add(new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = ""
            });

            return listadoProyectos;
        }
    }
}
