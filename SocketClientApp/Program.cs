using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteNetLib;

namespace SocketClientApp
{
    static class Program
    {
        public static readonly EventBasedNetListener Listener = new EventBasedNetListener();
        public static readonly NetManager Client = new NetManager(Listener);
        public static NetPeer LocalPeer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Client.Start();
            LocalPeer = Client.Connect("localhost", 1576, "BigStinky");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}