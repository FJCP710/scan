using scan.Data;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System;
using SQLite;
using scan.Services;

namespace scan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        MedicinaRepository medicinaRepository = new MedicinaRepository();
        public ObservableCollection<string> Items;
        private readonly SQLiteConnection _database;

        public ListViewPage()
        {
            InitializeComponent();

            for(int i = 0; i < medicinaRepository.names.Count(); i++)
            {
                Items.Add(medicinaRepository.names[i]);
            }
            
            MyListView.ItemsSource =  Items;
            
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            bool answer = await DisplayAlert("Pregunta", "¿Quieres salir y ver el prospecto", "Sí", "No");
            if(answer == true)
            {
                string nombre = e.Item.ToString();
                string url = _database.Query<MedicinasDB>("SELECT url FROM medicinas WHERE nombre = "+nombre).ToString();
                await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
