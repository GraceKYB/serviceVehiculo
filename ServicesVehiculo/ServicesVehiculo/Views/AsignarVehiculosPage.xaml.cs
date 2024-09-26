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
    public partial class AsignarVehiculosPage : ContentPage
    {
        private readonly ApiService _apiService;
        public AsignarVehiculosPage()
        {
            InitializeComponent();
            _apiService = new ApiService();
            LoadClientes();
        }

        private async void LoadClientes()
        {
            var clientes = await _apiService.GetClientesAsync();
            ClientesListView.ItemsSource = clientes;
        }

        private async void OnClienteSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Cliente cliente)
            {
                await Navigation.PushAsync(new SelectVehiPage(cliente));
            }
        }
    }
}