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
    public partial class PortSettingDlg : Form
    {
        public int m_iPort;

        public PortSettingDlg()
        {
            InitializeComponent();
        }

        private void PortSettingDlg_Load(object sender, EventArgs e)
        {
            textBox_Port.Text = "9999";
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            m_iPort = Convert.ToInt32(textBox_Port.Text);
        }
    }
}
