using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Hardcodet.Wpf.TaskbarNotification;
using Desktop_Android_Notifier.Properties;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using Desktop_Android_Notifier.Service;
using Desktop_Android_Notifier.Notifications;

namespace Desktop_Android_Notifier
{
    public partial class Form1 : Form
    {
        const string messageTest = "v2/1234abc/22334455/SMS/555-555-5555/{0}";
        const string callTest = "v2/1234abc/22334455/RING/{0}/John Doe";
        const string batteryTest = "v2/1234abc/22334455/BATTERY/{0}/Battery {0}%";

        TaskbarIcon icon;
        NotificationReceiver receiver = new TestNotificationReceiver();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            icon.ShowBalloonTip("TXT Message From John Doe", "Hello world", Resources.android_sms_small);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //server.MessageEvent += new Action<string>(server_MessageEvent);
            

            icon = new TaskbarIcon();
            icon.Icon = Resources.android_notifier_icon;
            icon.TrayBalloonTipClicked += new System.Windows.RoutedEventHandler(icon_TrayBalloonTipClicked);

            receiver.RegisterHandler(new BasicPingHandler(icon));
            receiver.RegisterHandler(new BasicBatteryHandler(icon));
            receiver.RegisterHandler(new BasicSmsHandler(icon));
            receiver.RegisterHandler(new BasicPhoneHandler(icon));
            receiver.Start();
        }

        void server_MessageEvent(string message)
        {
            MessageBox.Show(message);
        }

        void icon_TrayBalloonTipClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Here are your messages!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            receiver.Stop();

            icon.Icon = null;
            icon.Dispose();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            if (receiver is TestNotificationReceiver)
            {
                var testReceiver = receiver as TestNotificationReceiver;

                testReceiver.Test(string.Format(messageTest, messageTextBox.Text));
            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (receiver is TestNotificationReceiver)
            {
                var testReceiver = receiver as TestNotificationReceiver;

                testReceiver.Test(string.Format(callTest, callTextBox.Text));
            }
        }

        private void batteryButton_Click(object sender, EventArgs e)
        {
            if (receiver is TestNotificationReceiver)
            {
                var testReceiver = receiver as TestNotificationReceiver;

                testReceiver.Test(string.Format(batteryTest, batteryTextBox.Text));
            }
        }
    }
}
