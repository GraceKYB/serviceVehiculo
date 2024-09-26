using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesVehiculo.Models
{
    public class Cliente
    {
        [JsonProperty("id_cliente")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("apellido")]
        public string Apellido { get; set; }

        [JsonProperty("cedula")]
        public string Cedula { get; set; }

        [JsonProperty("correo")]
        public string Correo { get; set; }

        [JsonProperty("edad")]
        public int Edad { get; set; }

        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }
    }
}
