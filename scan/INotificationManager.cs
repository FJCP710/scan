using System;
using System.Collections.Generic;
using System.Text;

namespace scan
{
    public interface INotificationManager
    {
        event EventHandler NotificationReceived;
        void Initialize();
        void SendNotification(string title, string message, DateTime notifyTime);
        void ReceiveNotification(string title, string message);
    }
}
