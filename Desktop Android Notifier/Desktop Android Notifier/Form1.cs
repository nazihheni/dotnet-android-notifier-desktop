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

namespace Desktop_Android_Notifier
{
    public partial class Form1 : Form
    {
        private 

        TaskbarIcon icon;
        NotificationReceiver server = new NotificationReceiver();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            icon.ShowBalloonTip("TXT Message From John Doe", "Hello world", Resources.android_sms);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server.MessageEvent += new Action<string>(server_MessageEvent);
            server.Start();

            icon = new TaskbarIcon();
            icon.Icon = TaskbarIcon.DefaultIcon;
            icon.TrayBalloonTipClicked += new System.Windows.RoutedEventHandler(icon_TrayBalloonTipClicked);
        }

        void server_MessageEvent(string message)
        {
            MessageBox.Show(message);
        }

        void icon_TrayBalloonTipClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Here are your messages!");
        }
    }
}
