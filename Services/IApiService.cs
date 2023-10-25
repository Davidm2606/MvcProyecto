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
    }
}
