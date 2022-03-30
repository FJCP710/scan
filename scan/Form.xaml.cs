using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using System;
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
            NotificationCenter.Current.NotificationReceived += Current_NotificationReceived;
            NotificationCenter.Current.NotificationTapped += Current_NotificationTapped;
            
        }

        

        private void Current_NotificationTapped(NotificationEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert("Recordatorio", "El recordatorio ha cumpido su misión", "Aceptar");
            });
        }

        private void Current_NotificationReceived(NotificationEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert("Hora del mecicamento", "Medicamento recordado con éxito", "Aceptar");
            });
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (/*string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(hourEntry.Text) ||*/ string.IsNullOrWhiteSpace(hourEntry.Text))
            {
                await DisplayAlert("Inválido", "No ha rellenado todos los campos", "Aceptar");
            }
            else
            {
                createNotification();
                //createReminder();
            }
        }

        private void createReminder()
        {
            throw new NotImplementedException();
        }

        public void createNotification()
        {
            var hour = hourEntry.Text;
            var day = dayEntry.Text;
            var notification = new NotificationRequest
            {
                BadgeNumber = 1,
                Description = "Recordatorio",
                Title = "Hora del medicamento",
                ReturningData = "",
                Schedule =
                {
                    NotifyTime = DateTime.Now.AddSeconds(Convert.ToDouble(hour)),
                    //NotifyTime = DateTime.UtcNow.AddHours(Convert.ToDouble(hour)),
                    NotifyRepeatInterval = TimeSpan.FromDays(Convert.ToDouble(day))
                },
                iOS =
                {
                    PlayForegroundSound = true,
                }
            };
                NotificationCenter.Current.Show(notification);
            
            
        }

        private void InitializeSettings()
        {
            //nameEntry.Text =
        }
    }
}