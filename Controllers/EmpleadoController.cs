using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Utilies;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IApiService _apiService;

        public EmpleadoController(IApiService apiService)
        {
            _apiService = apiService;
        }


        // GET: ProductoController  
        public async Task<IActionResult> Index1()
        {
            try
            {
                List<Empleados> empleado = await _apiService.obtenerEmpleado();
                return View(empleado);
            }
            catch (Exception e)
            {
                return View(new List<Empleados>());
            }
        }

        // GET: ProductoController/Details/5
        public async Task<ActionResult> Details(string cedula)
        {
            var empleado = await _apiService.obtenerEmpleado(cedula);
            if (empleado != null)
            {
                return View(empleado);
            }
            return RedirectToAction("Index1");
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Empleados empleado)
        {
            var pCreado = await _apiService.añadirEmpleado(empleado);
            if (pCreado)
            {
                return RedirectToAction(nameof(Index1));
            }
            return View(empleado);
        }

        // GET: ProductoController/Edit/5
        public async Task<IActionResult> Edit(string cedula)
        {
            var pEditar = await _apiService.obtenerEmpleado(cedula);
            if (pEditar != null)
            {
                return View(pEditar);
            }
            return RedirectToAction("Index1");
        }

        // POST: ProductoController/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Empleados empleado)
        {
            var pAEditar = await _apiService.actualizarEmpleado(empleado.Cedula, empleado);
            if (pAEditar != null)
            {
                return RedirectToAction(nameof(Index1));
            }
            return View(pAEditar);
        }


        // GET: ProductoController/Delete/5
        public ActionResult Delete(string cedula)
        {
            var producto = _apiService.eliminarEmpleado(cedula);
            return RedirectToAction(nameof(Index1));

        }

    }
}
