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
    public partial class TargetSettingDlg : Form
    {
        public string m_strTargetIPAddr;
        public int m_iPort;

        public TargetSettingDlg()
        {
            InitializeComponent();
        }

        private void TargetSettingDlg_Load(object sender, EventArgs e)
        {
            textBox_TargetAddr.Text = "127.0.0.1";
            textBox_TargetPort.Text = "9999";
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            m_strTargetIPAddr = textBox_TargetAddr.Text;
            m_iPort = Convert.ToInt32(textBox_TargetPort.Text);
        }
    }
}
