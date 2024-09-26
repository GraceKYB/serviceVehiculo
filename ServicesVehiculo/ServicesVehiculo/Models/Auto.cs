using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesVehiculo.Models
{
    public class Auto
    {
        [JsonProperty("id_vehiculo")]
        public int Id { get; set; }

        [JsonProperty("nom_vehiculo")]
        public string Nombre { get; set; }

        [JsonProperty("mod_vehiculo")]
        public string Modelo { get; set; }

        [JsonProperty("mar_vehiculo")]
        public string Marca { get; set; }

        [JsonProperty("col_vehiculo")]
        public string Color { get; set; }

        [JsonProperty("anio_vehiculo")]
        public int Anio { get; set; }

        [JsonProperty("pre_vehiculo")]
        public decimal Precio { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("imagenes")]
        public List<string> Imagenes { get; set; }  // Modificado para una sola imagen
    }
}
