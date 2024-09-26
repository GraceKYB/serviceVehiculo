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
    public partial class AutoDetailPage : ContentPage
    {
        private readonly AutoService _autoService;
        private readonly Auto _auto;


        public AutoDetailPage(Auto auto)
        {
            InitializeComponent();
            _autoService = new AutoService();
            _auto = auto;
            BindingContext = _auto;
        }
                
        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            _auto.Nombre = NombreEntry.Text;
            _auto.Modelo = ModeloEntry.Text;
            _auto.Marca = MarcaEntry.Text;
            _auto.Color = ColorEntry.Text;

            if (int.TryParse(AnioEntry.Text, out int anio))
            {
                _auto.Anio = anio;
            }
            else
            {
                // Maneja el error de año no válido
            }

            if (decimal.TryParse(PrecioEntry.Text, out decimal precio))
            {
                _auto.Precio = precio;
            }
            else
            {
                // Maneja el error de precio no válido
            }

            if (int.TryParse(StockEntry.Text, out int stock))
            {
                _auto.Stock = stock;
            }
            else
            {
                // Maneja el error de stock no válido
            }

            bool result = await _autoService.UpdateAutoAsync(_auto.Id, _auto);

            if (result)
            {
                await DisplayAlert("Éxito", "Auto actualizado exitosamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Error al actualizar el auto", "OK");
            }
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmar", "¿Estás seguro de que deseas eliminar este auto?", "Sí", "No");

            if (confirm)
            {
                bool result = await _autoService.DeleteAutoAsync(_auto.Id);

                if (result)
                {
                    await DisplayAlert("Éxito", "Auto eliminado exitosamente", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "Error al eliminar el auto", "OK");
                }
            }
        }
    }
}