
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IApiService
    {
        Task<List<Alimento>> obtenerProductos();
        Task<Alimento> obtenerProducto(int id);
        Task<bool> añadirProducto(Alimento producto);
        Task<bool> actualizarProducto(int id, Alimento producto);
        Task<bool> eliminarProducto(int id);

        Task<List<Empleados>> obtenerEmpleado();
        Task<Empleados> obtenerEmpleado(string cedula);
        Task<bool> añadirEmpleado(Empleados empleado);
        Task<bool> actualizarEmpleado(string cedula, Empleados empleado);
        Task<bool> eliminarEmpleado(string cedula);
        

        Task<List<Platos>> obtenerPlato();
        Task<Platos> obtenerPlato(int id);
        Task<bool> añadirPlato(Platos plato);
        Task<bool> actualizarPlato(int id, Platos plato);
        Task<bool> eliminarPlato(int id);
    }
}
