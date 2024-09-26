using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesVehiculo.Models
{
    public class Compra
    {
        [JsonProperty("id_cliente")]
        public int IdCliente { get; set; }

        [JsonProperty("vehiculos")]
        public Dictionary<int, int> Vehiculos { get; set; } // id_vehiculo -> cantidad

        [JsonProperty("placas")]
        public Dictionary<int, List<string>> Placas { get; set; } // id_vehiculo -> lista de placas

        [JsonProperty("fecha_comp")]
        public string FechaComp { get; set; }
    }
}
