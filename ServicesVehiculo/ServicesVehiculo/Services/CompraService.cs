using Newtonsoft.Json;
using ServicesVehiculo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculo.Services
{
    public  class CompraService
    {
        private readonly HttpClient _httpClient;

        public CompraService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://192.168.139.9:80/vehiApi/public/api/") };
        }
        // Métodos para Cliente
        public async Task<List<Cliente>> GetClientesAsync()
        {
            var response = await _httpClient.GetStringAsync("listar/clientes");
            return JsonConvert.DeserializeObject<List<Cliente>>(response);
        }

        // Métodos para Auto
        public async Task<List<Auto>> GetAutosAsync()
        {
            var response = await _httpClient.GetStringAsync("autos");
            return JsonConvert.DeserializeObject<List<Auto>>(response);
        }

        // Método para realizar compra
        public async Task<bool> RealizarCompraAsync(Compra compra)
        {
            var json = JsonConvert.SerializeObject(compra);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("realizar-compra", content);
            return response.IsSuccessStatusCode;
        }
    }
}
    

