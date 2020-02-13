namespace UDPChatClient
{
    partial class TargetSettingDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TargetAddr = new System.Windows.Forms.TextBox();
            this.textBox_TargetPort = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Port";
            // 
            // textBox_TargetAddr
            // 
            this.textBox_TargetAddr.Location = new System.Drawing.Point(240, 54);
            this.textBox_TargetAddr.Name = "textBox_TargetAddr";
            this.textBox_TargetAddr.Size = new System.Drawing.Size(216, 35);
            this.textBox_TargetAddr.TabIndex = 2;
            // 
            // textBox_TargetPort
            // 
            this.textBox_TargetPort.Location = new System.Drawing.Point(240, 102);
            this.textBox_TargetPort.Name = "textBox_TargetPort";
            this.textBox_TargetPort.Size = new System.Drawing.Size(216, 35);
            this.textBox_TargetPort.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(89, 172);
            this.button_OK.Margin = new System.Windows.Forms.Padding(6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(139, 46);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(287, 172);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(6);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(139, 46);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // TargetSettingDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 250);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_TargetPort);
            this.Controls.Add(this.textBox_TargetAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TargetSettingDlg";
            this.Text = "TargetSettingDlg";
            this.Load += new System.EventHandler(this.TargetSettingDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TargetAddr;
        private System.Windows.Forms.TextBox textBox_TargetPort;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}