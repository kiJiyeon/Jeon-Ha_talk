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

namespace JeonHa_talk
{
    public partial class UDPChatServer : Form
    {
        
        public int port_num;
        public UDPChatServer()
        {
            InitializeComponent();
        }

        public void Send_To(Socket socket, EndPoint endpoint, string welcome)
        {
            byte[] welcome_data = new byte[1024];
            welcome_data = Encoding.UTF8.GetBytes(welcome);
            socket.SendTo(welcome_data, endpoint);
        }

        public void Recieved_from(Socket socket, EndPoint remote_endpoint, string welcome_data)//
        {
            byte[] data_recv = new byte[1024];
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(welcome_data); // 임의의 데이터
            int undata = Convert.ToInt32(data);

            //int recv = socket.ReceiveFrom(data, ref remote_endpoint);
            string recv_data = Encoding.UTF8.GetString(data_recv, port_num, undata);

            socket.SendTo(Encoding.UTF8.GetBytes(recv_data), remote_endpoint);
        }

        public void main()
        {
            //Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //IPEndPoint EP = new IPEndPoint(IPAddress.Any, 0);
            //server_socket.Bind(EP);

            //port_num = 7777;


            //IPEndPoint sender = new IPEndPoint(IPAddress.Any, port_num);
            //EndPoint remoteEP = (EndPoint)sender;
            //string welcome_data = "Hello Data";

            ////server_socket.BeginReceiveFrom(data_buffer, 0, data_buffer.Length, SocketFlags.None, ref remoteEP, new AsyncCallback(Recieved_from),server_socket)

            //while (true)
            //{
            //    Recieved_from(server_socket, remoteEP, welcome_data);
            //    //Send_To(server_socket, remoteEP, welcome_data);

            //}

            //server_socket.Close();
            int recv = 0;
            byte[] data = new byte[1024];

            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9050);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(ep);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remoteEP = (EndPoint)sender;

            recv = server.ReceiveFrom(data, ref remoteEP);

            Console.WriteLine("[first] Message received from {0}", remoteEP.ToString());
            Console.WriteLine("[first] received data : {0}", Encoding.UTF8.GetString(data, 0, recv));

            string server_string = Encoding.UTF8.GetString(data, 0, recv);

            data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(data,0,recv));
            server.SendTo(data, remoteEP);
            Server_window.Text = Server_window.Text + "\n" + server_string;

        }


        private void server_connect_Click(object sender, EventArgs e)
        {
            main();

        }
    }
}
