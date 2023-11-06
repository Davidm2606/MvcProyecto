using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Empleados
    {
        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public int Edad { get; set; }
    }
}

