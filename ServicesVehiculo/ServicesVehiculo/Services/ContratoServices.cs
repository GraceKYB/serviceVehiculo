using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculo.Services
{
    internal class ContratoServices
    {
        private readonly HttpClient _httpClient;

        public ContratoServices()
        {
            _httpClient = new HttpClient();
        }

        public async Task<byte[]> DescargarContratoAsync(int contratoId)
        {
            try
            {
                var url = $"http://192.168.139.9:80/vehiApi/public/api/compra/contrato/{contratoId}";
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    // Manejar errores según el código de estado HTTP
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                // Manejar excepciones de red
                return null;
            }
        }
    }
}
    