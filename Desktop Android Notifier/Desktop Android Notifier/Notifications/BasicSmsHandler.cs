using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hardcodet.Wpf.TaskbarNotification;
using Desktop_Android_Notifier.Properties;

namespace Desktop_Android_Notifier.Notifications
{
    class BasicSmsHandler: INotificationHandler
    {
        TaskbarIcon icon;

        public BasicSmsHandler(TaskbarIcon icon)
        {
            this.icon = icon;
        }

        public NotificationEvent NotificationType
        {
            get { return NotificationEvent.Sms; }
        }

        public void Process(Notification n)
        {
            icon.ShowBalloonTip("TXT " + n.Data, n.Contents, Resources.android_sms_small);
        }
    }
}
