using ServicesVehiculo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ServicesVehiculo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnClientesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }
        private async void OnVehiculosClicked(object sender, EventArgs e)
        {
            // Reemplaza `VehiculosPage` con el nombre de la página correspondiente
            await Navigation.PushAsync(new AutosPage());
        }
        private async void OnAsignarVehiculosClicked(object sender, EventArgs e)
        {
            // Reemplaza `AsignarVehiculosPage` con el nombre de la página correspondiente
            await Navigation.PushAsync(new AsignarVehiculosPage());
        }
        private async void OnVerContratoClicked(object sender, EventArgs e)
        {
            // Reemplaza `AsignarVehiculosPage` con el nombre de la página correspondiente
            await Navigation.PushAsync(new ContratoPage());
        }
        private async void OnBusquedaCedClicked(object sender, EventArgs e)
        {
            // Reemplaza `AsignarVehiculosPage` con el nombre de la página correspondiente
            await Navigation.PushAsync(new BusquedaPage());
        }
        private async void OnBusquedaPlacaClicked(object sender, EventArgs e)
        {
            // Reemplaza `AsignarVehiculosPage` con el nombre de la página correspondiente
            await Navigation.PushAsync(new BusquedaPlaca());
        }
    }
}
