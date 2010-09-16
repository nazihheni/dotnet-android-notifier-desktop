using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desktop_Android_Notifier.Notifications
{
    enum NotificationVersion
    {
        v1,
        v2
    }

    enum NotificationEvent
    {
        Ring,
        Sms,
        Mms,
        Battery,
        Ping
    }

    class Notification
    {
        public NotificationVersion Version { get; private set; }
        public string DeviceId { get; private set; }
        public string Id { get; private set; }
        public NotificationEvent Event { get; private set; }
        public string Data { get; set; }
        public string Contents { get; set; }

        public void Read(string s)
        {
            int start = 0;
            int index = s.IndexOf('/');
            
            string value = s.Substring(start, index);

            // we only handled version messages
            if(value != "v2")
                throw new Exception("Version 1 Messages are not handled");

            Version = NotificationVersion.v2;

            // Device Id
            start = index + 1;
            index = s.IndexOf('/', start);

            DeviceId = s.Substring(start, index - start);

            // Notification Id
            start = index + 1;
            index = s.IndexOf('/', start);

            Id = s.Substring(start, index - start);

            // Event
            start = index + 1;
            index = s.IndexOf('/', start);

            value = s.Substring(start, index - start);

            switch (value)
            {
                case "SMS":
                    Event = NotificationEvent.Sms;
                    break;
                case "RING":
                    Event = NotificationEvent.Ring;
                    break;
                case "MMS":
                    Event = NotificationEvent.Mms;
                    break;
                case "BATTERY":
                    Event = NotificationEvent.Battery;
                    break;
                case "PING":
                    Event = NotificationEvent.Ping;
                    break;
                default:
                    throw new Exception("Event type unknown");
            }

            // Data
            start = index + 1;
            index = s.IndexOf('/', start);

            Data = s.Substring(start, index - start);

            // Contents
            Contents = s.Substring(index + 1);
        }
    }
}
