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
    public partial class ConnectDlg : Form
    {
        public string m_strIPAddr;
        public int m_iPort;

        public ConnectDlg()
        {
            InitializeComponent();
        }

        private void ConnectDlg_Load(object sender, EventArgs e)
        {
            textBox_ServerAddr.Text = "127.0.0.1";
            textBox_ServerPort.Text = "1234";
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            m_strIPAddr = textBox_ServerAddr.Text;
            m_iPort = Convert.ToInt32(textBox_ServerPort.Text);
        }
    }
}
