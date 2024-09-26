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
    public partial class SelectVehiPage : ContentPage
    {
        private readonly CompraService  _compraService;
        private Cliente _cliente;
        private List<Auto> _vehiculos;
        private Auto _selectedAuto;
        public SelectVehiPage(Cliente cliente)
        {
            InitializeComponent();
            _compraService = new CompraService();
            _cliente = cliente;
            LoadVehiculos();
        }

        private async void LoadVehiculos()
        {
            _vehiculos = await _compraService.GetAutosAsync();
            VehiculosListView.ItemsSource = _vehiculos;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Auto auto)
            {
                _selectedAuto = auto;
            }
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            if (_selectedAuto == null)
            {
                await DisplayAlert("Error", "Please select a vehicle", "OK");
                return;
            }

            var selectedVehiculos = new Dictionary<int, int>
            {
                { _selectedAuto.Id, 1 } // Asume cantidad 1, ajustar según la lógica
            };

            await Navigation.PushAsync(new CantPlacaPage(_cliente, selectedVehiculos));
        }
    }
}