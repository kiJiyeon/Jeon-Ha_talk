using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace JeonHa_talk
{
    class Target_info
    {
        public Socket socket;
        public byte[] bufffer;
    }

    class UDP_Socket
    {
        Socket cli_socket;
        Socket mutual_udp_socket;
        IPEndPoint receive_EP;
        IPEndPoint cli_EP;
        Target_info mutual_target_info;
        EndPoint send_Endpoint;
        int openPort;


        int n;
        string data;
        
       

        public void openSocket(int port)
        {
            mutual_target_info = new Target_info();
            mutual_udp_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            openPort = port;
            receive_EP = new IPEndPoint(IPAddress.Any, openPort);
            EndPoint remote_Endpoint = new IPEndPoint(IPAddress.Any, 0);
            mutual_udp_socket.Bind(receive_EP);
            mutual_udp_socket.BeginReceiveFrom(
                mutual_target_info.bufffer,
                0,
                mutual_target_info.bufffer.Length,
                SocketFlags.None,
                ref remote_Endpoint,
                new AsyncCallback(receive_from_target_cli),
                mutual_udp_socket
                );

        }

        public void receive_from_target_cli(IAsyncResult result)
        {
            try
            {
                EndPoint remote_Endpoint = new IPEndPoint(IPAddress.Any, 0);
                int data_length = this.mutual_udp_socket.EndReceiveFrom(result, ref remote_Endpoint);
                // 
            }
            finally
            {
                mutual_udp_socket.BeginReceiveFrom(
                    mutual_target_info.bufffer,
                    0,
                    mutual_target_info.bufffer.Length,
                    SocketFlags.None,
                    ref send_Endpoint,
                    new AsyncCallback(receive_from_target_cli),
                    mutual_udp_socket);
            }


        }

    }
}
