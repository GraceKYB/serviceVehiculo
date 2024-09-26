using Newtonsoft.Json;
using ServicesVehiculo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculo.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://192.168.139.9:80/vehiApi/public/api/") };
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            var response = await _httpClient.GetStringAsync("listar/clientes");
            return JsonConvert.DeserializeObject<List<Cliente>>(response);
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            var response = await _httpClient.GetStringAsync($"clientes/{id}");
            return JsonConvert.DeserializeObject<Cliente>(response);
        }

        public async Task<bool> AddClienteAsync(Cliente cliente)
        {
            var json = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("clientes/nuevo", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateClienteAsync(int id, Cliente cliente)
        {
            try
            {
                // Serializa el objeto cliente a JSON con el formato que tu servidor espera
                var json = JsonConvert.SerializeObject(new
                {
                    nombre = cliente.Nombre,
                    apellido = cliente.Apellido,
                    cedula = cliente.Cedula,
                    correo = cliente.Correo,
                    edad = cliente.Edad,
                    direccion = cliente.Direccion,
                    estado = cliente.Estado // Asegúrate de que esto es necesario o debería ser un valor fijo
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Construye la URL completa para la solicitud PUT
                var url = $"clientes/editar/{id}";
                // Realiza la solicitud PUT
                var response = await _httpClient.PutAsync(url, content);

                // Maneja la respuesta
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Maneja excepciones
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }


        public async Task<bool> DeleteClienteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"clientes/eliminar/{id}");
            return response.IsSuccessStatusCode;
        }
        public async Task<BusquedaResponse> BuscarClienteAsync(string cedula)
        {
            var response = await _httpClient.GetStringAsync($"busqueda/cedula?cedula={cedula}");
            var data = JsonConvert.DeserializeObject<BusquedaResponse>(response);
            return data;
        }
        public async Task<List<VehiculoDetalle>> BuscarPorPlacaAsync(string placa)
        {
            var response = await _httpClient.GetStringAsync($"busqueda/placa?placa={placa}");
            var data = JsonConvert.DeserializeObject<List<VehiculoDetalle>>(response);
            return data;
        }
    }
}
