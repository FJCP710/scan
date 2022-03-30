using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System;
using SQLite;

namespace scan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<string> Items;

        
        public ListViewPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>()
            {
                "Item 1",
                "Item 2"
            };
            
            MyListView.ItemsSource =  Items;
            
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                MyListView.ItemsSource = await App.MyDatabase.ReadMedicinas();
            }
            catch (Exception ex)
            {

            }

        }
        private void listViewPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
