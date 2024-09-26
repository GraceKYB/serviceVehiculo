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
    public partial class BusquedaPlaca : ContentPage
    {
        private readonly ApiService _apiService;
        public BusquedaPlaca()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void OnBuscarVehiculoClicked(object sender, EventArgs e)
        {
            string placa = placaEntry.Text;
            if (!string.IsNullOrWhiteSpace(placa))
            {
                var resultados = await BuscarVehiculosPorPlaca(placa);
                resultadosListView.ItemsSource = resultados;
            }
        }

        private async Task<List<VehiculoDetalle>> BuscarVehiculosPorPlaca(string placa)
        {
            try
            {
                return await _apiService.BuscarPorPlacaAsync(placa);
            }
            catch (Exception ex)
            {
                // Manejar excepción y mostrar mensaje de error
                await DisplayAlert("Error", $"No se pudo obtener la información: {ex.Message}", "OK");
                return new List<VehiculoDetalle>();
            }
        }
    }
}