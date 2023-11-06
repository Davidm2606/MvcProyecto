using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication1.Models
{
    public class Platos
    {
        public int IdPlato { get; set; }

        public string? Nombre { get; set; }
        public string? Ingredientes { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }


    }
}
