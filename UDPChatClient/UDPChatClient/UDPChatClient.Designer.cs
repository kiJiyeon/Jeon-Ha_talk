namespace UDPChatClient
{
    partial class UDPChatClient
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
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_SetTarget = new System.Windows.Forms.Button();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_OpenSocket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(965, 550);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 578);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(965, 35);
            this.textBox_Input.TabIndex = 1;
            this.textBox_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Input_KeyPress);
            // 
            // button_SetTarget
            // 
            this.button_SetTarget.Location = new System.Drawing.Point(983, 63);
            this.button_SetTarget.Name = "button_SetTarget";
            this.button_SetTarget.Size = new System.Drawing.Size(161, 45);
            this.button_SetTarget.TabIndex = 2;
            this.button_SetTarget.Text = "Set Target";
            this.button_SetTarget.UseVisualStyleBackColor = true;
            this.button_SetTarget.Click += new System.EventHandler(this.button_SetTarget_Click);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(983, 573);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(161, 45);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(983, 527);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(161, 35);
            this.textBox_Name.TabIndex = 5;
            // 
            // button_OpenSocket
            // 
            this.button_OpenSocket.Location = new System.Drawing.Point(983, 12);
            this.button_OpenSocket.Name = "button_OpenSocket";
            this.button_OpenSocket.Size = new System.Drawing.Size(161, 45);
            this.button_OpenSocket.TabIndex = 3;
            this.button_OpenSocket.Text = "Open Socket";
            this.button_OpenSocket.UseVisualStyleBackColor = true;
            this.button_OpenSocket.Click += new System.EventHandler(this.button_OpenSocket_Click);
            // 
            // UDPChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 624);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.button_OpenSocket);
            this.Controls.Add(this.button_SetTarget);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.richTextBox_Output);
            this.Name = "UDPChatClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_SetTarget;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_OpenSocket;
    }
}

