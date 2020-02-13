using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChatClient
{
    public partial class UDPChatClient : Form
    {
        private UDPSocket m_Socket;
        private bool m_openedSocket;
        int m_openedPort;
        string m_targetAddr;
        int m_targetPort;

        public UDPChatClient()
        {
            InitializeComponent();
            m_openedSocket = false;
            m_openedPort = 0;
        }

        private void button_OpenSocket_Click(object sender, EventArgs e)
        {
            if (m_openedSocket == false)
            {
                PortSettingDlg dlg = new PortSettingDlg();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    m_openedPort = dlg.m_iPort;
                    m_Socket = new UDPSocket(this);
                    m_Socket.openSocket(m_openedPort);
                    m_openedSocket = true;
                    button_OpenSocket.Text = "Close Socket";
                }
            }
            else
            {
                m_Socket.closeSocket();
                button_OpenSocket.Text = "Open Socket";
            }

        }

        public void outputMessage(string msg)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                    delegate ()
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

        public void recvFrom(byte[] buffer)
        {
            outputMessage(Encoding.UTF8.GetString(buffer));
        }

        private void textBox_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // TextBox에서 Enter키를 눌렀을 때
                button_Send.PerformClick();
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Input.Text.Length > 0)
            {
                m_Socket.sendPacket(Encoding.UTF8.GetBytes(textBox_Name.Text + " : " + textBox_Input.Text));
                outputMessage(textBox_Name.Text + " : " + textBox_Input.Text);
                textBox_Input.Text = "";
            }
        }

        private void button_SetTarget_Click(object sender, EventArgs e)
        {
            TargetSettingDlg dlg = new TargetSettingDlg();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_targetAddr = dlg.m_strTargetIPAddr;
                m_targetPort = dlg.m_iPort;

                m_Socket.setTarget(m_targetAddr, m_targetPort);
            }
        }
    }
}
