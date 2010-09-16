using System;
using Desktop_Android_Notifier.Notifications;
using System.Collections.Generic;
namespace Desktop_Android_Notifier.Service
{
    abstract class NotificationReceiver
    {
        Dictionary<NotificationEvent, INotificationHandler> handlers = new Dictionary<NotificationEvent, INotificationHandler>(5);

        public void RegisterHandler(INotificationHandler handler)
        {
            handlers.Add(handler.NotificationType, handler);   
        }

        public void UnregisterHandler(INotificationHandler handler)
        {
            handlers.Remove(handler.NotificationType);
        }

        public abstract void Start();
        public abstract void Stop();

        protected void HandleNotification(Notification n)
        {
            INotificationHandler handler;

            if (handlers.TryGetValue(n.Event, out handler))
                handler.Process(n);
        }
    }
}
