using System.Diagnostics;
using Fastfixer_Web.Data;
using Fastfixer_Web.Models;
using Fastfixer_Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Fastfixer_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FastfixerDbContext _db;

        public HomeController(ILogger<HomeController> logger, FastfixerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var clientes = _db.Clientes.ToList(); // 🔹 Obtiene los clientes
            if (!clientes.Any()) // 🔹 Si no hay clientes, mostrar mensaje
            {
                ViewBag.Mensaje = "No hay clientes registrados en la base de datos.";
            }
            return View(clientes);
        }

        public IActionResult Detalle(int id)
        {
            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


