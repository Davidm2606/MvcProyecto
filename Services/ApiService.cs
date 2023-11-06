using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebApplication1.Models;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace WebApplication1.Services
{
    public class ApiService : IApiService
    {
        private static string _baseUrl;

        public ApiService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();   
            _baseUrl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<List<Alimento>> obtenerProductos()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync("/api/Alimento");
            var json_response = await response.Content.ReadAsStringAsync();
            List<Alimento> productos = JsonConvert.DeserializeObject<List<Alimento>>(json_response);
            return productos;
        }

        public async Task<List<Empleados>> obtenerEmpleado()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync("/api/Empleado");
            var json_response = await response.Content.ReadAsStringAsync();
            List<Empleados> empleado = JsonConvert.DeserializeObject<List<Empleados>>(json_response);
            return empleado;
        }

        public async Task<List<Platos>> obtenerPlato()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync("/api/Plato");
            var json_response = await response.Content.ReadAsStringAsync();
            List<Platos> productos = JsonConvert.DeserializeObject<List<Platos>>(json_response);
            return productos;
        }

        public async Task<Alimento> obtenerProducto(int id)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync($"/api/Alimento/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var producto = JsonConvert.DeserializeObject<Alimento>(content);
                return producto;
            }
            return null;

        }


        public async Task<Empleados> obtenerEmpleado(string cedula)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync($"/api/Empleado/{cedula}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var producto = JsonConvert.DeserializeObject<Empleados>(content);
                return producto;
            }
            return null;

        }
    
        


        public async Task<Platos> obtenerPlato(int IdPlato)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync($"/api/Plato/{IdPlato}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var producto = JsonConvert.DeserializeObject<Platos>(content);
                return producto;
            }
            return null;

        }

        public async Task<bool> añadirProducto(Alimento producto)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(producto);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"/api/Alimento", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> añadirEmpleado(Empleados empleado)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(empleado);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"/api/Empleado", content);
            return response.IsSuccessStatusCode;
        }


        public async Task<bool> añadirPlato(Platos plato)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(plato);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"/api/Plato", content);
            return response.IsSuccessStatusCode;
        }


        public async Task<bool> actualizarProducto(int id, Alimento producto)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(producto);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"/api/Alimento/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> actualizarEmpleado(string cedula, Empleados empleado)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(empleado);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"/api/Empleado/{cedula}", content);
            return response.IsSuccessStatusCode;
        }



        public async Task<bool> actualizarPlato(int IdPlato, Platos plato)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var jsonString = JsonConvert.SerializeObject(plato);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"/api/Plato/{IdPlato}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> eliminarEmpleado(string cedula)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.DeleteAsync($"/api/Empleado/{cedula}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> eliminarProducto(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.DeleteAsync($"/api/Alimento/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> eliminarPlato(int IdPlato)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.DeleteAsync($"/api/Plato/{IdPlato}");
            return response.IsSuccessStatusCode;
        }

       
    }
}
