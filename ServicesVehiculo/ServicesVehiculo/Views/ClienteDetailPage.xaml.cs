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
    public partial class ClienteDetailPage : ContentPage
    {
        private readonly ApiService _apiService;
        private readonly Cliente _cliente;
        public ClienteDetailPage(Cliente cliente)
        {
            InitializeComponent();
            _apiService = new ApiService();
            _cliente = cliente;
            BindingContext = _cliente;

        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            // Convertir los valores de Entry a los tipos correctos
            _cliente.Nombre = NombreEntry.Text;
            _cliente.Apellido = ApellidoEntry.Text;
            _cliente.Cedula = CedulaEntry.Text;
            _cliente.Correo = CorreoEntry.Text;

            // Intentar convertir Edad a un int
            if (int.TryParse(EdadEntry.Text, out int edad))
            {
                _cliente.Edad = edad;
            }
            else
            {
                await DisplayAlert("Error", "La edad ingresada no es válida", "OK");
                return;
            }

            _cliente.Direccion = DireccionEntry.Text;
            _cliente.Estado = "A"; // O cualquier valor que necesites

            bool isUpdated = await _apiService.UpdateClienteAsync(_cliente.Id, _cliente);
            if (isUpdated)
            {
                await DisplayAlert("Éxito", "Cliente actualizado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "No se pudo actualizar el cliente", "OK");
            }
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            // Mostrar alerta de confirmación
            bool confirm = await DisplayAlert("Confirmar", "¿Estás seguro de que deseas eliminar este cliente?", "Sí", "No");

            if (confirm)
            {
                bool isDeleted = await _apiService.DeleteClienteAsync(_cliente.Id);
                if (isDeleted)
                {
                    await DisplayAlert("Éxito", "Cliente eliminado correctamente", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo eliminar el cliente", "OK");
                }
            }
        }
    }
}