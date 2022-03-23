using Xamarin.Forms;
using System.IO;
using scan.Services;
using System.Reflection;
using scan.Data;
using System.Collections.ObjectModel;

namespace scan
{
    public partial class MainPage : ContentPage
    {
        public string id;
        public ObservableCollection<MedicinasDB> Medicinas { get; set; } = 
            new ObservableCollection<MedicinasDB>();
        /*
        public static SQLiteHelper Mydatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "medicinas.db"));

                }
                return db;
            }
        }
        */
        public MainPage()
        {
            InitializeComponent();

            // TODO Only do this when app first runs
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream =
                assembly.GetManifestResourceStream("scan.medicinas.db"))
            {
                using(MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);

                    File.WriteAllBytes(MedicinaRepository.DbPath, memoryStream.ToArray());
                }
            }
            MedicinaRepository repository = new MedicinaRepository();
            foreach(var medicina in repository.GetName())
            {
                Medicinas.Add(medicina);
            }
            BindingContext = this;
            
        }

        public void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                id = result.Text + " (type: " + result.BarcodeFormat.ToString() + ")";
            });
        }
    }
}
