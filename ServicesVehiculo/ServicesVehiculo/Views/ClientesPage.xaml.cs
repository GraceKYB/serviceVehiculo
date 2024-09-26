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
    public partial class ClientesPage : ContentPage
    {
        private readonly ApiService _apiService;
        public ClientesPage()
        {
            InitializeComponent();
            _apiService = new ApiService();
            CargarClientes();
        }

        private async void CargarClientes()
        {
            List<Cliente> clientes = await _apiService.GetClientesAsync();
            if(clientes == null || clientes.Count == 0)
            {
                await DisplayAlert("Información", "No se encontro clientes.", "OK");
            }else
            {
                ClientesListView.ItemsSource = clientes;
            }
            
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var cliente = e.SelectedItem as Cliente;
            await Navigation.PushAsync(new ClienteDetailPage(cliente));
        }
        private async void OnNuevoClienteClicked(object sender, EventArgs e)
        {
            // Navegar a la página de nuevo cliente
            await Navigation.PushAsync(new NuevoClientePage());
        }
    }
}