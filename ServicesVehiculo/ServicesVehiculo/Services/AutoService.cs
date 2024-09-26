using Newtonsoft.Json;
using ServicesVehiculo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculo.Services
{
    public class AutoService
    {
        private readonly HttpClient _httpClient;

        public AutoService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://192.168.139.9:80/vehiApi/public/api/") };
        }

        public async Task<List<Auto>> GetAutosAsync()
        {
            var response = await _httpClient.GetStringAsync("autos");
            return JsonConvert.DeserializeObject<List<Auto>>(response);
        }

        public async Task<Auto> GetAutoAsync(int id)
        {
            var response = await _httpClient.GetStringAsync($"autos/{id}");
            return JsonConvert.DeserializeObject<Auto>(response);
        }

        public async Task<bool> AddAutoAsync(Auto auto, string imagePath)
        {
            try
            {
                var form = new MultipartFormDataContent();

                // Añadir los datos del auto como JSON
                var autoData = new
                {
                    auto.Nombre,
                    auto.Modelo,
                    auto.Marca,
                    auto.Color,
                    auto.Anio,
                    auto.Precio,
                    auto.Stock
                };

                var json = JsonConvert.SerializeObject(autoData);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                form.Add(stringContent, "auto");

                // Leer y añadir la imagen
                if (!string.IsNullOrEmpty(imagePath))
                {
                    var fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    var streamContent = new StreamContent(fileStream);
                    streamContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg"); // Ajustar el tipo según la imagen
                    form.Add(streamContent, "image", Path.GetFileName(imagePath));
                }

                var response = await _httpClient.PostAsync("autos/nuevo", form);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateAutoAsync(int id, Auto auto)
        {
            try
            {
                var json = JsonConvert.SerializeObject(new
                {
                    nombre = auto.Nombre,
                    modelo = auto.Modelo,
                    marca = auto.Marca,
                    color = auto.Color,
                    anio = auto.Anio,
                    precio = auto.Precio,
                    stock = auto.Stock,
                    estado = auto.Estado // Asegúrate de que esto es necesario o debería ser un valor fijo
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var url = $"autos/editar/{id}";

                var response = await _httpClient.PutAsync(url, content);

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
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteAutoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"autos/eliminar/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
