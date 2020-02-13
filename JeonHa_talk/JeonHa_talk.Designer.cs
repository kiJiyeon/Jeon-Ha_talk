namespace JeonHa_talk
{
    partial class JeonHa_talk
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
            this.button_send = new System.Windows.Forms.Button();
            this.text_input = new System.Windows.Forms.TextBox();
            this.text_window = new System.Windows.Forms.TextBox();
            this.list_friends = new System.Windows.Forms.ListBox();
            this.chatting_room = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.list_present_chatting = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(381, 325);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(126, 35);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // text_input
            // 
            this.text_input.AcceptsReturn = true;
            this.text_input.Location = new System.Drawing.Point(29, 301);
            this.text_input.Multiline = true;
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(339, 59);
            this.text_input.TabIndex = 1;
            this.text_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_input_KeyDown);
            // 
            // text_window
            // 
            this.text_window.Location = new System.Drawing.Point(29, 40);
            this.text_window.Multiline = true;
            this.text_window.Name = "text_window";
            this.text_window.Size = new System.Drawing.Size(339, 249);
            this.text_window.TabIndex = 2;
            // 
            // list_friends
            // 
            this.list_friends.FormattingEnabled = true;
            this.list_friends.ItemHeight = 12;
            this.list_friends.Location = new System.Drawing.Point(381, 139);
            this.list_friends.Name = "list_friends";
            this.list_friends.Size = new System.Drawing.Size(126, 148);
            this.list_friends.TabIndex = 3;
            // 
            // chatting_room
            // 
            this.chatting_room.AutoSize = true;
            this.chatting_room.Location = new System.Drawing.Point(27, 17);
            this.chatting_room.Name = "chatting_room";
            this.chatting_room.Size = new System.Drawing.Size(51, 12);
            this.chatting_room.TabIndex = 4;
            this.chatting_room.Text = "Chatting";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(381, 301);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(126, 20);
            this.button_connect.TabIndex = 5;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // list_present_chatting
            // 
            this.list_present_chatting.FormattingEnabled = true;
            this.list_present_chatting.ItemHeight = 12;
            this.list_present_chatting.Location = new System.Drawing.Point(381, 40);
            this.list_present_chatting.Name = "list_present_chatting";
            this.list_present_chatting.Size = new System.Drawing.Size(126, 88);
            this.list_present_chatting.TabIndex = 6;
            // 
            // JeonHa_talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 387);
            this.Controls.Add(this.list_present_chatting);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.chatting_room);
            this.Controls.Add(this.list_friends);
            this.Controls.Add(this.text_window);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.button_send);
            this.Name = "JeonHa_talk";
            this.Text = "JeonHa_talk";
            this.Load += new System.EventHandler(this.JeonHa_talk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.TextBox text_window;
        private System.Windows.Forms.ListBox list_friends;
        private System.Windows.Forms.Label chatting_room;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ListBox list_present_chatting;
    }
}

