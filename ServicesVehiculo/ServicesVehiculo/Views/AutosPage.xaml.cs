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
    public partial class AutosPage : ContentPage
    {
        private readonly AutoService _autoService;

        public AutosPage()
        {
            InitializeComponent();
            _autoService = new AutoService();
            CargarAutos();
        }

        private async void CargarAutos()
        {
            List<Auto> autos = await _autoService.GetAutosAsync();
            if (autos == null || autos.Count == 0)
            {
                await DisplayAlert("Información", "No se encontraron autos.", "OK");
            }
            else
            {
                AutosListView.ItemsSource = autos;
            }
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var auto = e.SelectedItem as Auto;
            await Navigation.PushAsync(new AutoDetailPage(auto));
        }

        private async void OnNuevoAutoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevoAutoPage());
        }
    }
}