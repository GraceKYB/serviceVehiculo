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
    public partial class BusquedaPage : ContentPage
    {
        private readonly ApiService _apiService;
        public BusquedaPage()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void OnBuscarContratosClicked(object sender, EventArgs e)
        {
            var cedula = CedulaEntry.Text;

            if (string.IsNullOrWhiteSpace(cedula))
            {
                await DisplayAlert("Error", "Por favor, ingrese una cédula.", "OK");
                return;
            }

            var busquedaResponse = await _apiService.BuscarClienteAsync(cedula);

            if (busquedaResponse != null && busquedaResponse.Cliente != null)
            {
                ClienteInfoLabel.Text = $"Nombre: {busquedaResponse.Cliente.Nombre}\n" +
                                        $"Correo: {busquedaResponse.Cliente.Correo}\n" +
                                        $"Dirección: {busquedaResponse.Cliente.Direccion}";
                VehiculosListView.ItemsSource = busquedaResponse.Vehiculos;
            }
            else
            {
                await DisplayAlert("Error", "Cliente no encontrado.", "OK");
                ClienteInfoLabel.Text = string.Empty;
                VehiculosListView.ItemsSource = null;
            }
        }
    }
}