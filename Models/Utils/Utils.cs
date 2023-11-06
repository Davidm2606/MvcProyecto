

namespace WebApplication1.Models.Utilies
{
    public class Utils
    {

        static public List<Platos> ListaPlatos = new List<Platos>()
        {
            new Platos
            {
                IdPlato = 1,
                Nombre = "Salchipapa",
                Ingredientes = "salchicha",
                Cantidad = 1,
                Precio = 3,
            },

           new Platos
            {
                IdPlato = 2,
                Nombre = "Hamburguesa",
                Ingredientes = "carne",
                Cantidad = 1,
                Precio = 4,
            },

            new Platos
            {
                IdPlato = 3,
                Nombre = "Papicarne",
                Ingredientes = "carne",
                Cantidad = 1,
                Precio = 3,
            },

           new Platos
            {
                IdPlato = 4,
                Nombre = "Alitas",
                Ingredientes = "4 alitas",
                Cantidad = 4,
                Precio = 5,
            }

        };

        static public List<Empleados> ListaEmpleados = new List<Empleados>()
        {
            new Empleados
            {
                Cedula = "1721533980",
                Nombre = "David",
                Apellido = "Terán",
                Edad = 22,
            },

            new Empleados
            {
                 Cedula = "1700154550",
                Nombre = "Katya",
                Apellido = "Molina",
                Edad = 43,
            },

            new Empleados
            {
                 Cedula = "17154550",
                Nombre = "Cristian",
                Apellido = "Terán",
                Edad = 40,
            },

            new Empleados
            {
                 Cedula = "1700377052",
                Nombre = "Carmen",
                Apellido = "Rea",
                Edad = 34,
            }

        };


        static public List<Alimento> ListaProductos = new List<Alimento>()
        {
         new Alimento
                {
                    IdProducto = 1,
                    Nombre = "Salchichas",
                    Valor = 6,
                    Cantidad = 10
                },

                new Alimento
                {
                    IdProducto = 2,
                    Nombre = "carne",
                    Valor = 6,
                    Cantidad = 20
                },

                new Alimento
                {
                    IdProducto = 3,
                    Nombre = "Alitas",
                    Valor = 6,
                    Cantidad = 30
                }


        };
    }
}
