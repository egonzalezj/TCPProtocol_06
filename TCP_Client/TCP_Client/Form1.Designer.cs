namespace TCP_Client
{
    partial class frmTCP_Client
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
            this.txt_localIP = new System.Windows.Forms.TextBox();
            this.lbl_localIP = new System.Windows.Forms.Label();
            this.lbl_localPort = new System.Windows.Forms.Label();
            this.txt_localPort = new System.Windows.Forms.TextBox();
            this.lbl_connectionStatus = new System.Windows.Forms.Label();
            this.txt_connectionStatus = new System.Windows.Forms.TextBox();
            this.lbl_serverSection = new System.Windows.Forms.Label();
            this.lbl_serverIP = new System.Windows.Forms.Label();
            this.txt_serverIP_1 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_2 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_3 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_4 = new System.Windows.Forms.TextBox();
            this.lbl_serverPort = new System.Windows.Forms.Label();
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_localIP
            // 
            this.txt_localIP.BackColor = System.Drawing.Color.White;
            this.txt_localIP.Location = new System.Drawing.Point(61, 12);
            this.txt_localIP.Name = "txt_localIP";
            this.txt_localIP.ReadOnly = true;
            this.txt_localIP.Size = new System.Drawing.Size(107, 20);
            this.txt_localIP.TabIndex = 0;
            this.txt_localIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_localIP
            // 
            this.lbl_localIP.AutoSize = true;
            this.lbl_localIP.Location = new System.Drawing.Point(9, 15);
            this.lbl_localIP.Name = "lbl_localIP";
            this.lbl_localIP.Size = new System.Drawing.Size(46, 13);
            this.lbl_localIP.TabIndex = 1;
            this.lbl_localIP.Text = "Local IP";
            // 
            // lbl_localPort
            // 
            this.lbl_localPort.AutoSize = true;
            this.lbl_localPort.Location = new System.Drawing.Point(174, 15);
            this.lbl_localPort.Name = "lbl_localPort";
            this.lbl_localPort.Size = new System.Drawing.Size(55, 13);
            this.lbl_localPort.TabIndex = 2;
            this.lbl_localPort.Text = "Local Port";
            // 
            // txt_localPort
            // 
            this.txt_localPort.BackColor = System.Drawing.Color.White;
            this.txt_localPort.Location = new System.Drawing.Point(235, 12);
            this.txt_localPort.Name = "txt_localPort";
            this.txt_localPort.ReadOnly = true;
            this.txt_localPort.Size = new System.Drawing.Size(57, 20);
            this.txt_localPort.TabIndex = 3;
            this.txt_localPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_connectionStatus
            // 
            this.lbl_connectionStatus.AutoSize = true;
            this.lbl_connectionStatus.Location = new System.Drawing.Point(340, 15);
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            this.lbl_connectionStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_connectionStatus.TabIndex = 4;
            this.lbl_connectionStatus.Text = "Status";
            // 
            // txt_connectionStatus
            // 
            this.txt_connectionStatus.BackColor = System.Drawing.Color.Red;
            this.txt_connectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_connectionStatus.ForeColor = System.Drawing.Color.White;
            this.txt_connectionStatus.Location = new System.Drawing.Point(383, 12);
            this.txt_connectionStatus.Name = "txt_connectionStatus";
            this.txt_connectionStatus.ReadOnly = true;
            this.txt_connectionStatus.Size = new System.Drawing.Size(100, 20);
            this.txt_connectionStatus.TabIndex = 5;
            this.txt_connectionStatus.Text = "Not connected!";
            this.txt_connectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_serverSection
            // 
            this.lbl_serverSection.AutoSize = true;
            this.lbl_serverSection.Location = new System.Drawing.Point(9, 66);
            this.lbl_serverSection.Name = "lbl_serverSection";
            this.lbl_serverSection.Size = new System.Drawing.Size(77, 13);
            this.lbl_serverSection.TabIndex = 6;
            this.lbl_serverSection.Text = "Server Options";
            // 
            // lbl_serverIP
            // 
            this.lbl_serverIP.AutoSize = true;
            this.lbl_serverIP.Location = new System.Drawing.Point(9, 97);
            this.lbl_serverIP.Name = "lbl_serverIP";
            this.lbl_serverIP.Size = new System.Drawing.Size(51, 13);
            this.lbl_serverIP.TabIndex = 7;
            this.lbl_serverIP.Text = "Server IP";
            // 
            // txt_serverIP_1
            // 
            this.txt_serverIP_1.Location = new System.Drawing.Point(66, 94);
            this.txt_serverIP_1.MaxLength = 3;
            this.txt_serverIP_1.Name = "txt_serverIP_1";
            this.txt_serverIP_1.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_1.TabIndex = 8;
            this.txt_serverIP_1.Text = "127";
            this.txt_serverIP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_2
            // 
            this.txt_serverIP_2.Location = new System.Drawing.Point(113, 94);
            this.txt_serverIP_2.MaxLength = 3;
            this.txt_serverIP_2.Name = "txt_serverIP_2";
            this.txt_serverIP_2.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_2.TabIndex = 9;
            this.txt_serverIP_2.Text = "0";
            this.txt_serverIP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_3
            // 
            this.txt_serverIP_3.Location = new System.Drawing.Point(160, 94);
            this.txt_serverIP_3.MaxLength = 3;
            this.txt_serverIP_3.Name = "txt_serverIP_3";
            this.txt_serverIP_3.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_3.TabIndex = 10;
            this.txt_serverIP_3.Text = "0";
            this.txt_serverIP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_4
            // 
            this.txt_serverIP_4.Location = new System.Drawing.Point(207, 94);
            this.txt_serverIP_4.MaxLength = 3;
            this.txt_serverIP_4.Name = "txt_serverIP_4";
            this.txt_serverIP_4.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_4.TabIndex = 11;
            this.txt_serverIP_4.Text = "1";
            this.txt_serverIP_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_serverPort
            // 
            this.lbl_serverPort.AutoSize = true;
            this.lbl_serverPort.Location = new System.Drawing.Point(254, 97);
            this.lbl_serverPort.Name = "lbl_serverPort";
            this.lbl_serverPort.Size = new System.Drawing.Size(60, 13);
            this.lbl_serverPort.TabIndex = 12;
            this.lbl_serverPort.Text = "Server Port";
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Location = new System.Drawing.Point(320, 94);
            this.txt_serverPort.MaxLength = 5;
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(57, 20);
            this.txt_serverPort.TabIndex = 13;
            this.txt_serverPort.Text = "0";
            this.txt_serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(394, 92);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 14;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.White;
            this.txt_message.Enabled = false;
            this.txt_message.Location = new System.Drawing.Point(12, 164);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(236, 223);
            this.txt_message.TabIndex = 15;
            this.txt_message.TextChanged += new System.EventHandler(this.txt_message_TextChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 139);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(50, 13);
            this.lbl_message.TabIndex = 16;
            this.lbl_message.Text = "Message";
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.White;
            this.txt_data.Location = new System.Drawing.Point(257, 164);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.ReadOnly = true;
            this.txt_data.Size = new System.Drawing.Size(226, 223);
            this.txt_data.TabIndex = 17;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(254, 139);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(79, 13);
            this.lbl_data.TabIndex = 18;
            this.lbl_data.Text = "Data Received";
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(11, 404);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 19;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(408, 404);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmTCP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 439);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_serverPort);
            this.Controls.Add(this.lbl_serverPort);
            this.Controls.Add(this.txt_serverIP_4);
            this.Controls.Add(this.txt_serverIP_3);
            this.Controls.Add(this.txt_serverIP_2);
            this.Controls.Add(this.txt_serverIP_1);
            this.Controls.Add(this.lbl_serverIP);
            this.Controls.Add(this.lbl_serverSection);
            this.Controls.Add(this.txt_connectionStatus);
            this.Controls.Add(this.lbl_connectionStatus);
            this.Controls.Add(this.txt_localPort);
            this.Controls.Add(this.lbl_localPort);
            this.Controls.Add(this.lbl_localIP);
            this.Controls.Add(this.txt_localIP);
            this.Name = "frmTCP_Client";
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.frmTCP_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_localIP;
        private System.Windows.Forms.Label lbl_localIP;
        private System.Windows.Forms.Label lbl_localPort;
        private System.Windows.Forms.TextBox txt_localPort;
        private System.Windows.Forms.Label lbl_connectionStatus;
        private System.Windows.Forms.TextBox txt_connectionStatus;
        private System.Windows.Forms.Label lbl_serverSection;
        private System.Windows.Forms.Label lbl_serverIP;
        private System.Windows.Forms.TextBox txt_serverIP_1;
        private System.Windows.Forms.TextBox txt_serverIP_2;
        private System.Windows.Forms.TextBox txt_serverIP_3;
        private System.Windows.Forms.TextBox txt_serverIP_4;
        private System.Windows.Forms.Label lbl_serverPort;
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_close;
    }
}

