using Fastfixer_Web.Data;
using Fastfixer_Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
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

        //  Mostrar lista de clientes
        public IActionResult Index()
        {
            var clientes = _db.Clientes.ToList();
            return View(clientes);
        }

        //  Crear cliente (Formulario)
        public IActionResult Create()
        {
            return View();
        }

        //  Guardar cliente en la BD
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

        //  Editar cliente (Formulario)
        public IActionResult Edit(int id)
        {
            var cliente = _db.Clientes.Find(id);
            if (cliente == null) return NotFound();
            return View(cliente);
        }

        //  Guardar cambios en la BD
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

        //  Confirmar eliminación
        public IActionResult Delete(int id)
        {
            var cliente = _db.Clientes.Find(id);
            if (cliente == null) return NotFound();
            return View(cliente);
        }

        //  Eliminar cliente de la BD
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _db.Clientes.Find(id);
            if (cliente != null)
            {
                _db.Clientes.Remove(cliente);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
