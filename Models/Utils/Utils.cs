namespace WebApplication1.Models.Utilies
{
    public class Utils
    {
        static public List<Alimento> ListaProductos = new List<Alimento>()
        {
            new Alimento
            {
                IdProducto = 1,
                Nombre = "p1",
                Valor = 5,
                Cantidad = 1
            },

            new Alimento
            {
                IdProducto = 2,
                Nombre = "p2",
                Valor = 4,
                Cantidad = 2
            },

            new Alimento
            {
                IdProducto = 3,
                Nombre = "p3",
                Valor= 3,
                Cantidad = 3
            },

            new Alimento
            {
                IdProducto = 4,
                Nombre = "p4",
                Valor = 6,
                Cantidad = 4
            }

        };
    }
}
