namespace UDPChatServer
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
            this.Address_Label = new System.Windows.Forms.Label();
            this.Port_Label = new System.Windows.Forms.Label();
            this.Sever_Address = new System.Windows.Forms.TextBox();
            this.Port_Number = new System.Windows.Forms.TextBox();
            this.Server_Connect = new System.Windows.Forms.Button();
            this.server_window = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Address_Label.Location = new System.Drawing.Point(35, 22);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(77, 16);
            this.Address_Label.TabIndex = 0;
            this.Address_Label.Text = "서버 주소";
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Port_Label.Location = new System.Drawing.Point(371, 25);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(77, 16);
            this.Port_Label.TabIndex = 1;
            this.Port_Label.Text = "포트 번호";
            // 
            // Sever_Address
            // 
            this.Sever_Address.Location = new System.Drawing.Point(124, 22);
            this.Sever_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sever_Address.Name = "Sever_Address";
            this.Sever_Address.Size = new System.Drawing.Size(241, 21);
            this.Sever_Address.TabIndex = 2;
            // 
            // Port_Number
            // 
            this.Port_Number.Location = new System.Drawing.Point(460, 22);
            this.Port_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Port_Number.Multiline = true;
            this.Port_Number.Name = "Port_Number";
            this.Port_Number.Size = new System.Drawing.Size(120, 25);
            this.Port_Number.TabIndex = 3;
            // 
            // Server_Connect
            // 
            this.Server_Connect.Location = new System.Drawing.Point(593, 22);
            this.Server_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Server_Connect.Name = "Server_Connect";
            this.Server_Connect.Size = new System.Drawing.Size(83, 24);
            this.Server_Connect.TabIndex = 5;
            this.Server_Connect.Text = "연결";
            this.Server_Connect.UseVisualStyleBackColor = true;
            this.Server_Connect.Click += new System.EventHandler(this.Server_Connect_Click);
            // 
            // server_window
            // 
            this.server_window.Location = new System.Drawing.Point(12, 61);
            this.server_window.Multiline = true;
            this.server_window.Name = "server_window";
            this.server_window.Size = new System.Drawing.Size(663, 365);
            this.server_window.TabIndex = 7;
            // 
            // UDPChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(687, 438);
            this.Controls.Add(this.server_window);
            this.Controls.Add(this.Server_Connect);
            this.Controls.Add(this.Port_Number);
            this.Controls.Add(this.Sever_Address);
            this.Controls.Add(this.Port_Label);
            this.Controls.Add(this.Address_Label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UDPChatServer";
            this.Text = "UDPChatServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Port_Label;
        private System.Windows.Forms.TextBox Sever_Address;
        private System.Windows.Forms.TextBox Port_Number;
        private System.Windows.Forms.Button Server_Connect;
        private System.Windows.Forms.TextBox server_window;
    }
}

