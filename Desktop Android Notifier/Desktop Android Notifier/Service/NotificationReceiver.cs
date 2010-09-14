using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace Desktop_Android_Notifier.Service
{
    class NotificationReceiver
    {
        static readonly Guid BluetoothNotificationSerivce = Guid.Parse("7674047E-6E47-4BF0-831F-209E3F9DD23F");

        BluetoothListener listener;

        public event Action<string> MessageEvent;

        public NotificationReceiver()
        {
            listener = new BluetoothListener(BluetoothNotificationSerivce);
            listener.ServiceName = "AndroidNotifierService";
        }

        public void Start()
        {
            listener.Start();
            listener.BeginAcceptBluetoothClient(new AsyncCallback(AcceptClient), null);
        }

        public void AcceptClient(IAsyncResult result)
        {
            byte[] buffer = new byte[1024];
            StringBuilder message = new StringBuilder();

            try
            {
                using (var connection = listener.EndAcceptBluetoothClient(result))
                {
                    using (var stream = connection.GetStream())
                    {
                        int bytesRead = 0;
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            message.Append(Encoding.ASCII.GetChars(buffer, 0, bytesRead));
                        }

                        stream.Close();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                message.Append(ex.Message);
            }
            finally
            {
                if (MessageEvent != null)
                    MessageEvent(message.ToString());

                listener.BeginAcceptBluetoothClient(new AsyncCallback(AcceptClient), null);
            }
        }
    }
}
