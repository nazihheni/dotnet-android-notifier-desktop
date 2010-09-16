using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hardcodet.Wpf.TaskbarNotification;
using Desktop_Android_Notifier.Properties;

namespace Desktop_Android_Notifier.Notifications
{
    class BasicPhoneHandler: INotificationHandler
    {
        TaskbarIcon icon;

        public BasicPhoneHandler(TaskbarIcon icon)
        {
            this.icon = icon;
        }

        public NotificationEvent NotificationType
        {
            get { return NotificationEvent.Ring; }
        }

        public void Process(Notification n)
        {
            icon.ShowBalloonTip("Phone Call", n.Contents, Resources.call);
        }
    }
}
