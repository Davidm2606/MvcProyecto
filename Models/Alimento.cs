using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication1.Models
{
    public class Alimento
    {
 
        public int IdProducto { get; set; }
        public required string Nombre { get; set; }
        public int Valor { get; set; }
        public int Cantidad { get; set; }

      

       
    }
}
