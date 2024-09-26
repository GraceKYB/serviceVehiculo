using ServicesVehiculo.Models;
using ServicesVehiculo.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServicesVehiculo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoAutoPage : ContentPage
    {
        private readonly AutoService _autoService;
        private string _imagenRuta;
        public NuevoAutoPage()
        {
            InitializeComponent();
            _autoService = new AutoService();
        }
        private async void OnSeleccionarImagenClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await MediaPicker.PickPhotoAsync();
                if (result != null)
                {
                    var stream = await result.OpenReadAsync();
                    ImagenVehiculo.Source = ImageSource.FromStream(() => stream);

                    // Guardar la ruta de la imagen para enviarla al servidor
                    _imagenRuta = result.FullPath; // Guardar la ruta completa del archivo
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al seleccionar imagen: {ex.Message}", "OK");
            }
        }

        private async void OnAgregarClicked(object sender, EventArgs e)
        {
            // Validación básica de los campos
            if (string.IsNullOrWhiteSpace(NombreEntry.Text) || string.IsNullOrWhiteSpace(ModeloEntry.Text) ||
                string.IsNullOrWhiteSpace(MarcaEntry.Text) || string.IsNullOrWhiteSpace(ColorEntry.Text) ||
                string.IsNullOrWhiteSpace(AnioEntry.Text) || string.IsNullOrWhiteSpace(PrecioEntry.Text) ||
                string.IsNullOrWhiteSpace(StockEntry.Text))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }

            if (!int.TryParse(AnioEntry.Text, out int anio) || !decimal.TryParse(PrecioEntry.Text, out decimal precio) || !int.TryParse(StockEntry.Text, out int stock))
            {
                await DisplayAlert("Error", "Verifica que los campos Año, Precio y Stock sean correctos", "OK");
                return;
            }

            // Crear el objeto Auto
            var nuevoAuto = new Auto
            {
                Nombre = NombreEntry.Text,
                Modelo = ModeloEntry.Text,
                Marca = MarcaEntry.Text,
                Color = ColorEntry.Text,
                Anio = anio,
                Precio = precio,
                Stock = stock
                // Imagenes = new List<string> { _imagenRuta } // Usar para enviar la ruta de imagen si es necesario
            };

            // Llamar al método para agregar el auto
            bool isAdded = await _autoService.AddAutoAsync(nuevoAuto, _imagenRuta);
            if (isAdded)
            {
                await DisplayAlert("Éxito", "Auto agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "No se pudo agregar el auto", "OK");
            }
        }
    }
}