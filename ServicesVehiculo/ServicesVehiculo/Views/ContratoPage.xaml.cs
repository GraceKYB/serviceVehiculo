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
    public partial class ContratoPage : ContentPage
    {
        private readonly ContratoServices _contratoServices;
        public ContratoPage()
        {
            InitializeComponent();
            _contratoServices = new ContratoServices();
        }

        private async void OnBuscarContratoClicked(object sender, EventArgs e)
        {
            if (int.TryParse(ContratoIdEntry.Text, out int contratoId))
            {
                var pdfBytes = await _contratoServices.DescargarContratoAsync(contratoId);

                if (pdfBytes != null)
                {
                    // Guarda el archivo PDF en el dispositivo
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "contrato.pdf");
                    File.WriteAllBytes(filePath, pdfBytes);

                    // Usa Xamarin.Essentials para abrir el archivo PDF en un visor externo
                    await Launcher.OpenAsync(filePath);
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo descargar el contrato.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese un ID válido.", "OK");
            }
        }
    }
}