using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Desktop_Android_Notifier.Notifications;

namespace Desktop_Android_Notifier.Service
{
    class TestNotificationReceiver : NotificationReceiver
    {
        public override void Start()
        {
            
        }

        public override void Stop()
        {
            
        }

        public void Test(string message)
        {
            Notification n = new Notification();
            n.Read(message);

            HandleNotification(n);
        }
    }
}
