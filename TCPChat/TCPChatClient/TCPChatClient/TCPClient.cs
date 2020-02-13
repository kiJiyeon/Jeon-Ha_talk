using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPChatClient
{
    class ConnectionInfo
    {
        public Socket socket;
        public byte[] buffer;
    }

    class TCPClient
    {
        Socket m_connectSocket;
        ConnectionInfo m_connectServer;
        IPEndPoint m_Server;

        TCPChatClient m_parentForm;

        public TCPClient(TCPChatClient form)
        {
            m_parentForm = form;
        }

        public void connect(string addr, int port)
        {
            m_connectSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_connectSocket.Blocking = false;
            m_connectSocket.BeginConnect(addr, port, new AsyncCallback(ConnectCallback), m_connectSocket);
        }

        public void disconnect()
        {
            if (m_connectServer.socket.Connected == true)
            {
                m_connectServer.socket.BeginDisconnect(false, new AsyncCallback(DisconnectCallBack), m_connectServer);
            }
        }

        public void DisconnectCallBack(IAsyncResult result)
        {
            m_parentForm.disconnectToServer();
            m_connectServer.socket.Close();
            m_connectSocket.Close();
        }

        public void ConnectCallback(IAsyncResult result)
        {
            try
            {
                Socket s = (Socket)result.AsyncState;
                m_Server = (IPEndPoint)s.RemoteEndPoint;
                m_connectServer = new ConnectionInfo();
                m_connectServer.buffer = new byte[256];
                s.EndConnect(result);
                m_connectServer.socket = s;

                m_parentForm.connectToServer();

                m_connectServer.socket.BeginReceive(
                    m_connectServer.buffer,
                    0,
                    m_connectServer.buffer.Length,
                    SocketFlags.None,
                    new AsyncCallback(ReceiveCallback),
                    m_connectServer);
            }
            catch (SocketException)
            {

            }
        }

        public void ReceiveCallback(IAsyncResult result)
        {
            ConnectionInfo conn = (ConnectionInfo)result.AsyncState;
            try
            {
                if (conn.socket.Connected == false)
                {
                    conn.socket.Close();
                    disconnect();
                    return;
                }

                int packetLength = conn.socket.EndReceive(result);
                if (packetLength != 0)
                {
                    m_parentForm.recvFromServer(conn.buffer);
                    conn.socket.BeginReceive(conn.buffer, 0, conn.buffer.Length, SocketFlags.None,
                        new AsyncCallback(ReceiveCallback), conn);
                }
                else
                {
                    conn.socket.Close();
                    disconnect();
                    m_parentForm.disconnectToServer();
                }
            }
            catch (SocketException)
            {
                conn.socket.Close();
                m_connectSocket.Close();
            }
        }

        public void sendPacket(byte[] packet)
        {
           m_connectSocket.Send(packet, packet.Length, SocketFlags.None);
        }
    }
}
