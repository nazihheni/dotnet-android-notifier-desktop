using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hardcodet.Wpf.TaskbarNotification;
using Desktop_Android_Notifier.Properties;

namespace Desktop_Android_Notifier.Notifications
{
    class BasicPingHandler: INotificationHandler
    {
        TaskbarIcon icon;

        public BasicPingHandler(TaskbarIcon icon)
        {
            this.icon = icon;
        }

        public NotificationEvent NotificationType
        {
            get { return NotificationEvent.Ping; }
        }

        public void Process(Notification n)
        {
            icon.ShowBalloonTip("PING Message", n.Contents, Resources.android_sms_small);
        }
    }
}
