using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Form : ContentPage
    {
        public Form()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(hourEntry.Text))
            {
                await DisplayAlert("Inválido", "No ha rellenado todos los campos", "Aceptar");
            }
            else
            {
                createNotification();
                createReminder();
            }
        }

        private void createReminder()
        {
            throw new NotImplementedException();
        }

        private void createNotification()
        {
            throw new NotImplementedException();
        }
    }
}