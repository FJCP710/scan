using Xamarin.Forms;
using System.IO;
using scan.Models;
using System.Reflection;
using System.Collections.ObjectModel;

namespace scan
{
    public partial class MainPage : ContentPage
    {
        public string idMedicina;
        public ObservableCollection<MedicinasModel> Medicinas { get; set; } = 
            new ObservableCollection<MedicinasModel>();
        public ObservableCollection<string> nombres { get; set; }
        public MainPage()
        {
            InitializeComponent();
            /*
            // TODO Only do this when app first runs
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream =
                assembly.GetManifestResourceStream("scan.medicinas.db"))
            {
                using(MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    try
                    {
                        File.WriteAllBytes(MedicinaRepository.DbPath, memoryStream.ToArray());
                    } catch {
                        new IOException();
                    }
                   
                    // Aquí va un try catch
                }
            }
            MedicinaRepository repository = new MedicinaRepository();
            foreach(var medicina in repository.List())
            {
                Medicinas.Add(medicina);
            }
            BindingContext = this;
            */
        }

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResultText.Text = "Código: "+result.Text;
            });
            idMedicina = scanResultText.ToString();
        }
        public ObservableCollection<string> ListaNombres()
        {
            while (scanResultText.Text != null)
            {
                nombres.Add(idMedicina);
            }
            return nombres;
        }
    }
    
}
