using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using G20240408.EntidadesDeNegocio;
using G20240408.LogicaDeNegocio;
using Microsoft.AspNetCore.Identity;

namespace G20240408.UIAppWebMVC.Controllers
{
    public class PersonasController : Controller
    {
        readonly PersonaGBL _personaGBL;
      
        public PersonasController(PersonaGBL personaGBL)
        {
            _personaGBL = personaGBL;
        }

        // GET: PersonasController
        public async Task<ActionResult> Index(PersonaG personaG)
        {
            var personas = await _personaGBL.Buscar(personaG);
            return View(personas);
        }

        // GET: PersonasController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personasG = await _personaGBL.ObtenerPorId(new PersonaG { Id = id });
            return View(personasG);
        }

        // GET: PersonasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaG personaG)
        {
            try
            {
                await _personaGBL.Crear(personaG);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var PersonasG = await _personaGBL.ObtenerPorId(new PersonaG { Id = id });
            return View(PersonasG);
        }

        // POST: PersonasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaG personaG)
        {
            try
            {
                await _personaGBL.Modificar(personaG);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await _personaGBL.ObtenerPorId(new PersonaG { Id = id });
            return View(cliente);
        }

        // POST: PersonasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaG personaG)
        {
            try
            {
                await _personaGBL.Eliminar(personaG);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
