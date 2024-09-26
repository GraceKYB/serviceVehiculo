using ServicesVehiculo.Models;
using ServicesVehiculo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServicesVehiculo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoClientePage : ContentPage
    {
        private readonly ApiService _apiService;

        public NuevoClientePage()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void OnAgregarClicked(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(NombreEntry.Text) || string.IsNullOrWhiteSpace(ApellidoEntry.Text) ||
                string.IsNullOrWhiteSpace(CedulaEntry.Text) || string.IsNullOrWhiteSpace(CorreoEntry.Text) ||
                string.IsNullOrWhiteSpace(EdadEntry.Text) || string.IsNullOrWhiteSpace(DireccionEntry.Text))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }

            // Manejar la conversión de Edad
            if (!int.TryParse(EdadEntry.Text, out int edad))
            {
                await DisplayAlert("Error", "La edad debe ser un número válido", "OK");
                return;
            }

            // Crear el objeto Cliente
            var nuevoCliente = new Cliente
            {
                Nombre = NombreEntry.Text,
                Apellido = ApellidoEntry.Text,
                Cedula = CedulaEntry.Text,
                Correo = CorreoEntry.Text,
                Edad = edad,
                Direccion = DireccionEntry.Text,
                Estado = "A" // Estado activo
            };

            // Llamar al método para agregar el cliente
            bool isAdded = await _apiService.AddClienteAsync(nuevoCliente);
            if (isAdded)
            {
                await DisplayAlert("Éxito", "Cliente agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "No se pudo agregar el cliente", "OK");
            }
        }
    }
}