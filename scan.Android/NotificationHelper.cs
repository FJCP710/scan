using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace scan.Droid
{
    public class NotificationHelper : INotificationManager
    {
        public event EventHandler NotificationReceived;

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void ReceiveNotification(string title, string message)
        {
            throw new NotImplementedException();
        }

        public void SendNotification(string title, string message, DateTime notifyTime)
        {
            throw new NotImplementedException();
        }
    }
}