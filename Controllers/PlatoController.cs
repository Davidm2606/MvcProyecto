using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Utilies;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class PlatoController : Controller
    {

        private readonly IApiService _apiService;

        public PlatoController(IApiService apiService)
        {
            _apiService = apiService;
        }


        // GET: ProductoController  
        public async Task<IActionResult> Index2()
        {
            try
            {
                List<Platos> productos = await _apiService.obtenerPlato();
                return View(productos);
            }
            catch (Exception e)
            {
                return View(new List<Platos>());
            }
        }

        // GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int IdPlato)
        {
            var producto = await _apiService.obtenerPlato(IdPlato);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index2");
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Platos plato)
        {
            var pCreado = await _apiService.añadirPlato(plato);
            if (pCreado)
            {
                return RedirectToAction(nameof(Index2));
            }
            return View(plato);
        }

        // GET: ProductoController/Edit/5
        public async Task<IActionResult> Edit(int IdPlato)
        {
            var pEditar = await _apiService.obtenerPlato(IdPlato);
            if (pEditar != null)
            {
                return View(pEditar);
            }
            return RedirectToAction("Index2");
        }

        // POST: ProductoController/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Platos plato)
        {
            var pAEditar = await _apiService.actualizarPlato(plato.IdPlato, plato);
            if (pAEditar != null)
            {
                return RedirectToAction(nameof(Index2));
            }
            return View(pAEditar);
        }


        // GET: ProductoController/Delete/5
        public ActionResult Delete(int IdPlato)
        {
            var producto = _apiService.eliminarPlato(IdPlato);
            return RedirectToAction(nameof(Index2));

        }

    }
}
