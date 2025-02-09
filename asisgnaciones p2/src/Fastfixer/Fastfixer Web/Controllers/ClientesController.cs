using Fastfixer_Web.Data;
using Fastfixer_Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Fastfixer_Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly FastfixerDbContext _db;

        public ClientesController(FastfixerDbContext db)
        {
            _db = db;
        }

        // ✅ GET: Mostrar lista de clientes
        public IActionResult Index()
        {
            var clientes = _db.Clientes.ToList();
            if (!clientes.Any())
            {
                ViewBag.Mensaje = "No hay clientes disponibles.";
            }
            return View(clientes);
        }

        // ✅ GET: Mostrar detalles de un cliente
        public IActionResult Detalle(int id)
        {
            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // ✅ GET: Crear nuevo cliente (Formulario)
        public IActionResult Create()
        {
            return View();
        }

        // ✅ POST: Guardar nuevo cliente en la BD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // ✅ GET: Editar cliente (Formulario)
        public IActionResult Edit(int id)
        {
            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // ✅ POST: Guardar edición de cliente en la BD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(cliente);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // ✅ GET: Confirmar eliminación
        public IActionResult Delete(int id)
        {
            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // ✅ POST: Eliminar cliente de la BD
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _db.Clientes.Remove(cliente);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

