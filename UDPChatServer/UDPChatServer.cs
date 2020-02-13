using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;



namespace UDPChatServer
{


    public partial class UDPChatServer : Form
    {
        Socket socket;
        IPEndPoint endPoint;
        IPAddress ip;

        int port;
        string strIP;
        byte[] rBuffer;
  

        public UDPChatServer()
        {
            InitializeComponent();

            port = 8000;
            strIP = "127.0.0.1";
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            ip = IPAddress.Parse(strIP);
            endPoint = new IPEndPoint(ip, port);
        }

        private void Server_Connect_Click(object sender, EventArgs e)
        {

            socket.Bind(endPoint);
            rBuffer = new byte[1024];

            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(server_recvFrom),
                socket);

            socket.SendTo(rBuffer, endPoint);


        }
        public void server_recvFrom(IAsyncResult Result)
        {
            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            int datalen = socket.EndReceiveFrom(Result, ref remoteEndpoint);

            string result = Encoding.UTF8.GetString(rBuffer);
            server_window.Text = server_window.Text + "\n" + result;

            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(server_recvFrom),
                socket);


        }
    }
}
         
    


    

