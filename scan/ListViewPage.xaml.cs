using scan.Data;
using scan.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        //readonly MedicinasService medicinasService;
        public ObservableCollection<MedicinasDB> medicinas { get; set; }
        MedicinaRepository medicinaRepository;
        public ObservableCollection<string> medicinasList;
        public ListViewPage()
        {
            InitializeComponent();
            medicinasList.Add(medicinaRepository.n)
            /*
            foreach (string nombres in medicinaRepository.GetName())
            {
                medicinasList.Add(nombres);
            }
            */
            /*
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = Items;
            */
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
        /*
        protected override async void OnAppearing()
        {
            
            try
            {
                base.OnAppearing();
               // MyListView.ItemsSource = await MainPage.Mydatabase.ReadMedicine();
            }
            catch { }
        }
        */
    }
}
