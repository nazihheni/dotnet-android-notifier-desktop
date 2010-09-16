using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hardcodet.Wpf.TaskbarNotification;
using System.Drawing;
using Desktop_Android_Notifier.Properties;

namespace Desktop_Android_Notifier.Notifications
{
    class BasicBatteryHandler: INotificationHandler
    {
        TaskbarIcon icon;

        public BasicBatteryHandler(TaskbarIcon icon)
        {
            this.icon = icon;
        }

        public NotificationEvent NotificationType
        {
            get { return NotificationEvent.Battery; }
        }

        public void Process(Notification n)
        {
            int batteryLevel = int.Parse(n.Data);

            Icon batteryIcon;

            if (batteryLevel == 100)
                batteryIcon = Resources.battery_100;
            else if (batteryLevel >= 80)
                batteryIcon = Resources.battery_80;
            else if (batteryLevel >= 60)
                batteryIcon = Resources.battery_60;
            else if (batteryLevel >= 40)
                batteryIcon = Resources.battery_40;
            else if (batteryLevel >= 20)
                batteryIcon = Resources.battery_20;
            else if (batteryLevel >= 10)
                batteryIcon = Resources.battery_10;
            else
                batteryIcon = Resources.battery_0;

            icon.ShowBalloonTip(n.Contents, " ", batteryIcon);
        }
    }
}
