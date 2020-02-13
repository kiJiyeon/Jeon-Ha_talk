using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChatServer
{
    public partial class TCPChatServer : Form
    {
        private TCPServer m_serverSocket;
        private int m_iServerPort;

        public TCPChatServer()
        {
            InitializeComponent();
            m_iServerPort = Properties.Settings.Default.serverPort;
            button_Stop.Enabled = false;
        }

        public void outputMessage(string msg)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        richTextBox_Output.AppendText(msg);
                        richTextBox_Output.AppendText(Environment.NewLine);
                        richTextBox_Output.ScrollToCaret();
                    }
                    ));
            }
            catch (InvalidOperationException)
            {
                //throw new Exception(ex.Message);
            }
        }

        public void connectedFromClient(string clientIP)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        if (listBox_Users.Items.Contains(clientIP) == false)
                        {
                            listBox_Users.Items.Add(clientIP);
                            outputMessage(clientIP + " is connected");
                        }
                    }
                    ));
            }
            catch (InvalidOperationException)
            {
                //throw new Exception(ex.Message);
            }
        } 

        public void disconnectedFromClient(string clientIP)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        if (listBox_Users.Items.Contains(clientIP) == true)
                        {
                            listBox_Users.Items.Remove(clientIP);
                            outputMessage(clientIP + " is disconnected");
                        }
                    }
                    ));
            }
            catch (InvalidOperationException)
            {
                //throw new Exception(ex.Message);
            }
        }

        public void recvFromClientProc(string clientIP, byte[] buffer)
        {
            m_serverSocket.sendPacket2Client(clientIP, buffer);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            m_serverSocket = new TCPServer(this);
            m_serverSocket.listen(m_iServerPort);
            button_Stop.Enabled = true;
            button_Start.Enabled = false;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            m_serverSocket.closeSocket();
            listBox_Users.Items.Clear();
            outputMessage("Close server socket");
            button_Start.Enabled = true;
            button_Stop.Enabled = false;
        }

        private void TCPChatServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_serverSocket != null)
            {
                m_serverSocket.closeSocket();
            }
        }
    }
}
