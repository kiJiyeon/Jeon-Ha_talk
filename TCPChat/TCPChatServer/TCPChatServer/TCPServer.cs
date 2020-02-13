using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPChatServer
{
    class ConnectionInfo
    {
        public Socket socket;
        public byte[] buffer;
    }

    class TCPServer
    {
        Socket m_serverSocket;
        IPEndPoint m_requestEndPoint;

        TCPChatServer m_parentForm;

        Dictionary<string, ConnectionInfo> m_clientConnection;

        public TCPServer(TCPChatServer form)
        {
            m_parentForm = form;
            m_clientConnection = new Dictionary<string, ConnectionInfo>();
        }

        public void listen(int listenPort4Client)
        {
            m_serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_requestEndPoint = new IPEndPoint(IPAddress.Any, listenPort4Client);
            m_serverSocket.Blocking = false;
            m_serverSocket.Bind(m_requestEndPoint);
            m_serverSocket.Listen(20);
            m_serverSocket.BeginAccept(new AsyncCallback(AcceptCallback4ReporterClient), m_serverSocket);

        }

        public void AcceptCallback4ReporterClient(IAsyncResult result)
        {
            ConnectionInfo connection = new ConnectionInfo();
            connection.buffer = new byte[256];
            try
            {
                Socket s = (Socket)result.AsyncState;

                connection.socket = s.EndAccept(result);
                
                String clientIP = connection.socket.RemoteEndPoint.ToString();
                if (m_clientConnection.ContainsKey(clientIP))
                {
                    if (m_clientConnection[clientIP].socket.Connected == true)
                    {
                        m_clientConnection[clientIP].socket.Close();
                    }
                    m_clientConnection.Remove(clientIP);
                }

                m_clientConnection.Add(clientIP, connection);

                m_clientConnection[clientIP].socket.BeginReceive(
                    m_clientConnection[clientIP].buffer, 
                    0,
                    m_clientConnection[clientIP].buffer.Length, 
                    SocketFlags.None,
                    new AsyncCallback(ReceiveCallback4Client),
                    m_clientConnection[clientIP]);

                m_serverSocket.BeginAccept(new AsyncCallback(AcceptCallback4ReporterClient), m_serverSocket);
                m_parentForm.connectedFromClient(clientIP);
            }
            catch(SocketException)
            {
                return;
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            
        }

        public void ReceiveCallback4Client(IAsyncResult result)
        {
            ConnectionInfo connection = (ConnectionInfo)result.AsyncState;

            try
            {
                int packetLength = connection.socket.EndReceive(result);
                String clientIP = connection.socket.RemoteEndPoint.ToString();
                if (packetLength != 0)
                {
                    if (m_clientConnection.ContainsKey(clientIP) == false)
                    {
                        return;
                    }

                    m_parentForm.recvFromClientProc(clientIP, connection.buffer);

                    m_clientConnection[clientIP].socket.BeginReceive(
                        m_clientConnection[clientIP].buffer,
                        0,
                        m_clientConnection[clientIP].buffer.Length,
                        SocketFlags.None,
                        new AsyncCallback(ReceiveCallback4Client),
                        m_clientConnection[clientIP]);
                }
                else
                {
                    connection.socket.Close();
                    if (m_clientConnection.ContainsKey(clientIP) == true)
                    {
                        m_clientConnection.Remove(clientIP);
                    }
                    m_parentForm.disconnectedFromClient(clientIP);
                }
            }
            catch(SocketException)
            {
                return;
            }
            catch(ObjectDisposedException)
            {
                return;
            }
        }

        public void sendPacket2Client(string clientIP, byte[] packet)
        {
            foreach(KeyValuePair<string, ConnectionInfo> items in m_clientConnection)
            {
                items.Value.socket.Send(packet, packet.Length, SocketFlags.None);
            }    
        }

        public void closeSocket()
        {
            try
            {       
                foreach (KeyValuePair<string, ConnectionInfo> pair in m_clientConnection)
                {
                    if (pair.Value.socket.Connected == true)
                    {
                        pair.Value.socket.Disconnect(false);
                        pair.Value.socket.Close();
                    }
                }
                m_clientConnection.Clear();

                m_serverSocket.Close();
            }
            catch (SocketException)
            {
                return;
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }
    }
}
