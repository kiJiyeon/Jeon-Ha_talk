using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPChatClient
{
    class TargetInfo
    {
        public Socket socket;
        public byte[] buffer;
    }

    class UDPSocket
    {
        Socket m_udpSocket;
        TargetInfo m_targetInfo;
        IPEndPoint m_receiveEndpoint;
        EndPoint m_sendEndpoint;

        UDPChatClient m_parentForm;

        string m_targetAddr;
        int m_targetPort;
        int m_openPort;


        public UDPSocket(UDPChatClient form)
        {
            m_parentForm = form;
            m_targetAddr = "127.0.0.1";
            m_targetPort = 9999;
        }

        public void openSocket(int port)
        {
            try
            {
                m_targetInfo = new TargetInfo();
                m_targetInfo.buffer = new byte[256];
                m_udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                m_udpSocket.Blocking = false;
                m_openPort = port;
                m_receiveEndpoint = new IPEndPoint(IPAddress.Any, m_openPort);
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                m_udpSocket.Bind(m_receiveEndpoint);
                m_udpSocket.BeginReceiveFrom(
                    m_targetInfo.buffer,
                    0,
                    m_targetInfo.buffer.Length,
                    SocketFlags.None,
                    ref remoteEndpoint,
                    new AsyncCallback(recvfromTargetClient),
                    m_udpSocket);
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

        public void closeSocket()
        {
            m_udpSocket.Close();
            m_udpSocket = null;
            m_sendEndpoint = null;
            m_receiveEndpoint = null;
        }

        public void recvfromTargetClient(IAsyncResult result)
        {
            try
            {
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                int dataLen = this.m_udpSocket.EndReceiveFrom(result, ref remoteEndpoint);
                m_parentForm.recvFrom(m_targetInfo.buffer);
            }
            catch (SocketException)
            {

            }
            catch (ObjectDisposedException)
            {

            }
            finally
            {
                m_udpSocket.BeginReceiveFrom(
                    m_targetInfo.buffer,
                    0,
                    m_targetInfo.buffer.Length,
                    SocketFlags.None,
                    ref m_sendEndpoint,
                    new AsyncCallback(recvfromTargetClient),
                    m_udpSocket);
            }
        }

        public void setTarget(string addr, int port)
        {
            IPAddress targetAddr = IPAddress.Parse(addr);
            m_sendEndpoint = new IPEndPoint(targetAddr, port);
        }

        public void sendPacket(byte[] packet)
        {
            m_udpSocket.SendTo(packet, m_sendEndpoint);
        }
    }
}
