using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesVehiculo.Models
{
    public class VehiculoDetalle
    {
        [JsonProperty("usuario")]
        public Cliente Usuario { get; set; }

        [JsonProperty("vehiculo")]
        public Auto Vehiculo { get; set; }
    }

   
}
  

