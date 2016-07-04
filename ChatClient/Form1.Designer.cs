namespace ChatClient
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chatlistbox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendmsgbtn = new System.Windows.Forms.Button();
            this.sendrichtextbox = new System.Windows.Forms.RichTextBox();
            this.connectserverbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.receivebackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chatlistbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChatBox";
            // 
            // chatlistbox
            // 
            this.chatlistbox.FormattingEnabled = true;
            this.chatlistbox.Location = new System.Drawing.Point(6, 19);
            this.chatlistbox.Name = "chatlistbox";
            this.chatlistbox.Size = new System.Drawing.Size(448, 173);
            this.chatlistbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendmsgbtn);
            this.groupBox2.Controls.Add(this.sendrichtextbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SendBox";
            // 
            // sendmsgbtn
            // 
            this.sendmsgbtn.Location = new System.Drawing.Point(190, 131);
            this.sendmsgbtn.Name = "sendmsgbtn";
            this.sendmsgbtn.Size = new System.Drawing.Size(87, 23);
            this.sendmsgbtn.TabIndex = 1;
            this.sendmsgbtn.Text = "Send Message";
            this.sendmsgbtn.UseVisualStyleBackColor = true;
            // 
            // sendrichtextbox
            // 
            this.sendrichtextbox.Location = new System.Drawing.Point(6, 19);
            this.sendrichtextbox.Name = "sendrichtextbox";
            this.sendrichtextbox.Size = new System.Drawing.Size(448, 106);
            this.sendrichtextbox.TabIndex = 0;
            this.sendrichtextbox.Text = "";
            // 
            // connectserverbtn
            // 
            this.connectserverbtn.Location = new System.Drawing.Point(12, 426);
            this.connectserverbtn.Name = "connectserverbtn";
            this.connectserverbtn.Size = new System.Drawing.Size(104, 23);
            this.connectserverbtn.TabIndex = 1;
            this.connectserverbtn.Text = "Connect to Server";
            this.connectserverbtn.UseVisualStyleBackColor = true;
            this.connectserverbtn.Click += new System.EventHandler(this.sendmsgbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(397, 426);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(122, 431);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(37, 13);
            this.statuslbl.TabIndex = 3;
            this.statuslbl.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.connectserverbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox chatlistbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendmsgbtn;
        private System.Windows.Forms.RichTextBox sendrichtextbox;
        private System.Windows.Forms.Button connectserverbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label statuslbl;
        private System.ComponentModel.BackgroundWorker receivebackgroundWorker1;
    }
}

