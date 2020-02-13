namespace JeonHa_talk
{
    partial class UDPChatServer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Port_number = new System.Windows.Forms.TextBox();
            this.Server_window = new System.Windows.Forms.RichTextBox();
            this.server_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버 주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(530, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "포트 번호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 28);
            this.textBox1.TabIndex = 2;
            // 
            // Port_number
            // 
            this.Port_number.Location = new System.Drawing.Point(658, 34);
            this.Port_number.Margin = new System.Windows.Forms.Padding(4);
            this.Port_number.Name = "Port_number";
            this.Port_number.Size = new System.Drawing.Size(170, 28);
            this.Port_number.TabIndex = 3;
            
            // 
            // Server_window
            // 
            this.Server_window.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Server_window.ForeColor = System.Drawing.Color.White;
            this.Server_window.Location = new System.Drawing.Point(15, 95);
            this.Server_window.Margin = new System.Windows.Forms.Padding(4);
            this.Server_window.Name = "Server_window";
            this.Server_window.Size = new System.Drawing.Size(950, 539);
            this.Server_window.TabIndex = 4;
            this.Server_window.Text = "";
            // 
            // server_connect
            // 
            this.server_connect.Location = new System.Drawing.Point(848, 32);
            this.server_connect.Margin = new System.Windows.Forms.Padding(4);
            this.server_connect.Name = "server_connect";
            this.server_connect.Size = new System.Drawing.Size(119, 36);
            this.server_connect.TabIndex = 5;
            this.server_connect.Text = "연결";
            this.server_connect.UseVisualStyleBackColor = true;
            this.server_connect.Click += new System.EventHandler(this.server_connect_Click);
            // 
            // UDPChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.server_connect);
            this.Controls.Add(this.Server_window);
            this.Controls.Add(this.Port_number);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UDPChatServer";
            this.Text = "UDPChatServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Port_number;
        private System.Windows.Forms.RichTextBox Server_window;
        private System.Windows.Forms.Button server_connect;
    }
}

