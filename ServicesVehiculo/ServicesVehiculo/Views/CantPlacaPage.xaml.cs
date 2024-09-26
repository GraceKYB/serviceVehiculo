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
    public partial class CantPlacaPage : ContentPage
    {
        private readonly CompraService _compraService;
        private Cliente _cliente;
        private Dictionary<int, int> _vehiculos;

        public CantPlacaPage(Cliente cliente, Dictionary<int, int> vehiculos)
        {
            InitializeComponent();
            _compraService = new CompraService();
            _cliente = cliente;
            _vehiculos = vehiculos;
        }

        private void OnShowFormClicked(object sender, EventArgs e)
        {
            FormularioStackLayout.IsVisible = true;
        }

        private void OnShowPlacasFieldsClicked(object sender, EventArgs e)
        {
            if (int.TryParse(CantidadEntry.Text, out int cantidad))
            {
                PlacasStackLayout.Children.Clear();

                // Verificar stock
                if (cantidad > 0 && cantidad <= _vehiculos.Values.Max())
                {
                    for (int i = 1; i <= cantidad; i++)
                    {
                        var placaEntry = new Entry
                        {
                            Placeholder = $"Placa {i}",
                            Keyboard = Keyboard.Text
                        };
                        PlacasStackLayout.Children.Add(placaEntry);
                    }
                }
                else
                {
                    DisplayAlert("Error", "Cantidad no válida o fuera de stock.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese una cantidad válida.", "OK");
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (int.TryParse(CantidadEntry.Text, out int cantidad) && cantidad > 0)
            {
                var placas = new List<string>();
                foreach (var child in PlacasStackLayout.Children)
                {
                    if (child is Entry placaEntry && !string.IsNullOrWhiteSpace(placaEntry.Text))
                    {
                        placas.Add(placaEntry.Text);
                    }
                }

                if (placas.Count == cantidad)
                {
                    var compra = new Compra
                    {
                        IdCliente = _cliente.Id,
                        Vehiculos = new Dictionary<int, int> { { 1, cantidad } }, // Suponiendo un solo vehículo con ID 1
                        Placas = new Dictionary<int, List<string>> { { 1, placas } },
                        FechaComp = DateTime.Now.ToString("yyyy-MM-dd")
                    };

                    var success = await _compraService.RealizarCompraAsync(compra);
                    if (success)
                    {
                        await DisplayAlert("Éxito", "Su compra se ha realizado con éxito.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Error", "Hubo un problema al realizar la compra.", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "El número de placas no coincide con la cantidad ingresada.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese una cantidad válida.", "OK");
            }
        }
    }
}