using System;
using System.Linq;
using System.Threading;

using System.Windows.Forms;
using static SocketClientApp.Program;
using LiteNetLib;
using LiteNetLib.Utils;

namespace SocketClientApp
{
    public partial class Form1 : Form
    {
        private string _lastType = "Enter Message Here";
        int _movX,_movY;
        bool _isMoving;
        private string[] _blacklist = new[] { "REQUEST_USERS" };
        
        private bool _killPro;
        public Form1()
        {
            InitializeComponent();
            
            Connect();
        }
        
        private void AppendLine(string value)
        {
            if (MainText.Text.Length==0)
                MainText.Text = value;
            else
                MainText.AppendText("\r\n"+value);
        }

        private void UpdateClient()
        {
            while (!_killPro)
            {
                Client.PollEvents();
                Thread.Sleep(15);
            }
        }

        private void Connect()
        {
            Thread updateThread = new Thread(UpdateClient);
            updateThread.Start(); 
            string conString = $"Socket Client Id: {LocalPeer.RemoteId}";
            ConnectionLabel.Text = conString;
            MainText.Text = "";
            this.Text = $@"Socket Client Id: {LocalPeer.RemoteId}";
            AppendLine("-------------------------");
            AppendLine($@"Connected To Server {Client.FirstPeer.EndPoint} As Id: {LocalPeer.RemoteId}");
            AppendLine("-------------------------");
            Listener.NetworkReceiveEvent += (peer, reader, channel, method) =>
            {
                AppendLine(reader.GetString(100));
                AppendLine("-------------------------");
                reader.Recycle();
            };
            Listener.PeerDisconnectedEvent += (peer, info) =>
            {
                string dis = $"Server Disconnect : {info.Reason}";
                AppendLine(dis);
                AppendLine("-------------------------");
            };
            Members.Text = "";
        }
        
        private void Send_Click(object sender, EventArgs e)
        {
            if (TextInput.Text == @"Enter Message Here")
            {
                return;
            }
            NetDataWriter data = new NetDataWriter();
            data.Put(TextInput.Text);
            if (_blacklist.Contains(TextInput.Text))
            {
                AppendLine($@"Failed To Send Message Error 1543");
                AppendLine("-------------------------");
                TextInput.Text = @"Enter Message Here";
                _lastType = TextInput.Text;
                return;
            }
            AppendLine($@"You : {TextInput.Text}");
            AppendLine("-------------------------");
            TextInput.Text = @"Enter Message Here";
            _lastType = TextInput.Text;
            Client.SendToAll(data, DeliveryMethod.ReliableOrdered);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Client.DisconnectAll();
            Client.Stop();
            _killPro = true;
            Environment.Exit(0);
        }

        private void TextInput_Enter(object sender, EventArgs e)
        {
            if (TextInput.Text == @"Enter Message Here")
            {
                _lastType = TextInput.Text;
                TextInput.Text = "";
            }
            else
            {
                _lastType = TextInput.Text;
            }
        }

        private void TextInput_Leave(object sender, EventArgs e)
        {
            if (_lastType == "Enter Message Here")
            {
                if (TextInput.Text.Length < 1)
                {
                    TextInput.Text = @"Enter Message Here";
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            _movX = e.X;
            _movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - _movX, MousePosition.Y - _movY);
            }
        }
    }
}