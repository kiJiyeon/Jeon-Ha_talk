using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace JeonHa_talk
{
    public partial class JeonHa_talk : Form
    {
        string strIP;
        int port;
        Socket socket;
        IPAddress ip;
        IPEndPoint endPoint;
        byte[] rBuffer;

        public JeonHa_talk()
        {
            InitializeComponent();
            strIP = "127.0.0.1";
            port = 8000;

            //UDP Socket 생성
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //종점 생성
            ip = IPAddress.Parse(strIP);
            endPoint = new IPEndPoint(ip, port);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            text_window.Text = text_window.Text + "\n" + text_input.Text;
            text_input.Clear();
        }

        private void text_input_KeyDown(object sender, KeyEventArgs e)
        {
            // 수-필 시작
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                text_input.Text = text_input.Text + "\n";
                text_input.SelectionStart = text_input.Text.Length;

            }
            else if (e.KeyCode == Keys.Enter)
            {
                text_window.Text = text_window.Text + "\n" + text_input.Text;
                
                string msg = text_input.Text;

                byte[] sBuffer = Encoding.UTF8.GetBytes(msg);

                //보내기
                //socket.Send(sBuffer, 0, sBuffer.Length, SocketFlags.None);
                socket.SendTo(sBuffer, endPoint);//접속(Connect)를 안할거면 일케 SendTo로 할수 있다.

                text_input.Clear();

            }
            // 수-필 끝
        }


        private void JeonHa_talk_Load(object sender, EventArgs e)
        {
            this.ActiveControl = text_input; //커서가 텍스트박스에 깜빡이게 함
            text_input.Focus();
            text_window.ReadOnly = true;

            //전체창으로 띄우기 가능
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            //바인드
            socket.Connect(endPoint);

            rBuffer = new byte[1024];

            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(client_recvFrom),
                socket);
        }

        public void client_recvFrom(IAsyncResult Result)
        {
            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            int datalen = socket.EndReceiveFrom(Result, ref remoteEndpoint);

            string result = Encoding.UTF8.GetString(rBuffer);
            text_window.Text = text_window.Text + "\n" + result;
            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(client_recvFrom),
                socket);

        }
        /*private void 초대가능_SelectedIndexChanged(object sender, EventArgs e)
        {
            참여자목록.Items.Add(초대가능.SelectedItem.ToString());
            전체 연락처에서 채팅 참여자 리스트로 추가할 때 
        }*/



    }
}
