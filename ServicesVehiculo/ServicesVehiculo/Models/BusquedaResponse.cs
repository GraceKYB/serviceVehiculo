using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesVehiculo.Models
{
    public class BusquedaResponse
    {
        [JsonProperty("cliente")]
        public Cliente Cliente { get; set; }

        [JsonProperty("vehiculos")]
        public List<Auto> Vehiculos { get; set; }
    }
}
