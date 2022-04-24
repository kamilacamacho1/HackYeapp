using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Cultivo;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        CultivoModel model;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.model = new CultivoModel();
        }

        public IActionResult Index()
        {
            return View();
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

        // GET: /Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: /Create
        [HttpPost]
        public async Task<ActionResult> Create(CultivoEntity c)
        {

            var respuesta = await model.AddCultivo(c);
            if (respuesta == true)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No es posible registrar el libro, se alcanzó el máximo permitido.";
                return View("Error");
            }

        }
    }
}
