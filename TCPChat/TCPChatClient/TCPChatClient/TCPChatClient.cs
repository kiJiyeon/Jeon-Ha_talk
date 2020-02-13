using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChatClient
{
    public partial class TCPChatClient : Form
    {
        private TCPClient m_clientSocket;

        private string m_strServerIpAddr;
        private int m_iServerPort;

        public TCPChatClient()
        {
            InitializeComponent();
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

        public void connectToServer()
        {
            outputMessage("Connected to Server");
            
        }

        public void recvFromServer(byte[] buffer)
        {
            outputMessage(Encoding.Default.GetString(buffer));
        }

        public void disconnectToServer()
        {
            outputMessage("Disconnected to Server");
        }

        private void TCPChatClient_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // TextBox에서 Enter키를 눌렀을 때
                button_Send.PerformClick();
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Message.Text.Length > 0)
            {
                // Message 전송
                // TextBox 초기화
                m_clientSocket.sendPacket(Encoding.UTF8.GetBytes(textBox_Name.Text + " :  " + textBox_Message.Text));
                textBox_Message.Text = "";
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            m_clientSocket.disconnect();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ConnectDlg dlg = new ConnectDlg();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_strServerIpAddr = dlg.m_strIPAddr;
                m_iServerPort = dlg.m_iPort;

                m_clientSocket = new TCPClient(this);
                m_clientSocket.connect(m_strServerIpAddr, m_iServerPort);
            }
        }

        private void TCPChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.disconnect();
            }
        }

    }
}
