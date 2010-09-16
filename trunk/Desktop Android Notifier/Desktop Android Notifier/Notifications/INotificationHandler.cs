using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desktop_Android_Notifier.Notifications
{
    interface INotificationHandler
    {
        NotificationEvent NotificationType { get; }

        void Process(Notification n);
    }
}
