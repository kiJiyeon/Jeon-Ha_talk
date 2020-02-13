using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace UDP_Server
{
    class UDPChat_Server
    {
        static void main(string[] args)
        {
            new UDPChat_Server();
        }

        public UDPChat_Server()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9999);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(ipep);
            Console.WriteLine("Server Start!");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(sender);

            byte[] _data = new byte[1024];
            server.ReceiveFrom(_data, ref remote);
            Console.WriteLine("{0} : Receive : {1}", remote.ToString(), Encoding.Default.GetString(_data));

            _data = Encoding.Default.GetBytes("지연서버");
            server.SendTo(_data, _data.Length, SocketFlags.None, remote);

            server.Close();

            Console.WriteLine("Press Any Key ...");
            Console.ReadLine();

        }
    }


}