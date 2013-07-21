namespace ServerBlackwood
{
    partial class ServerBlackwoodMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerBlackwoodMain));
            this._togmsg = new System.Windows.Forms.Button();
            this._login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._report = new System.Windows.Forms.Button();
            this._ipaddress = new System.Windows.Forms.TextBox();
            this._un = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _togmsg
            // 
            this._togmsg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._togmsg.ForeColor = System.Drawing.Color.Black;
            this._togmsg.Location = new System.Drawing.Point(63, 89);
            this._togmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._togmsg.Name = "_togmsg";
            this._togmsg.Size = new System.Drawing.Size(21, 27);
            this._togmsg.TabIndex = 14;
            this._togmsg.Text = "!";
            this._togmsg.UseVisualStyleBackColor = false;
            this._togmsg.Click += new System.EventHandler(this._togmsg_Click);
            // 
            // _login
            // 
            this._login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._login.ForeColor = System.Drawing.Color.Black;
            this._login.Location = new System.Drawing.Point(8, 89);
            this._login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(51, 27);
            this._login.TabIndex = 13;
            this._login.Text = "login";
            this._login.UseVisualStyleBackColor = false;
            this._login.Click += new System.EventHandler(this._login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "User:";
            // 
            // _pw
            // 
            this._pw.BackColor = System.Drawing.SystemColors.HighlightText;
            this._pw.ForeColor = System.Drawing.Color.Red;
            this._pw.Location = new System.Drawing.Point(63, 57);
            this._pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pw.Name = "_pw";
            this._pw.PasswordChar = '*';
            this._pw.Size = new System.Drawing.Size(67, 22);
            this._pw.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _report
            // 
            this._report.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._report.Image = ((System.Drawing.Image)(resources.GetObject("_report.Image")));
            this._report.Location = new System.Drawing.Point(109, 89);
            this._report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._report.Name = "_report";
            this._report.Size = new System.Drawing.Size(21, 27);
            this._report.TabIndex = 21;
            this._report.UseVisualStyleBackColor = false;
            this._report.Click += new System.EventHandler(this._report_Click);
            // 
            // _ipaddress
            // 
            this._ipaddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this._ipaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerBlackwood.Properties.Settings.Default, "ipaddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._ipaddress.ForeColor = System.Drawing.Color.Black;
            this._ipaddress.Location = new System.Drawing.Point(63, 2);
            this._ipaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._ipaddress.Name = "_ipaddress";
            this._ipaddress.Size = new System.Drawing.Size(67, 22);
            this._ipaddress.TabIndex = 16;
            this._ipaddress.Text = global::ServerBlackwood.Properties.Settings.Default.ipaddress;
            // 
            // _un
            // 
            this._un.BackColor = System.Drawing.SystemColors.HighlightText;
            this._un.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._un.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerBlackwood.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._un.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._un.Location = new System.Drawing.Point(63, 30);
            this._un.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._un.Name = "_un";
            this._un.Size = new System.Drawing.Size(67, 22);
            this._un.TabIndex = 9;
            this._un.Text = global::ServerBlackwood.Properties.Settings.Default.un;
            // 
            // ServerBlackwoodMain
            // 
            this.AcceptButton = this._login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(135, 117);
            this.Controls.Add(this._report);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._ipaddress);
            this.Controls.Add(this._togmsg);
            this.Controls.Add(this._login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pw);
            this.Controls.Add(this._un);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ServerBlackwoodMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackwood";
            this.TrackEnabled = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerBlackwoodMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _togmsg;
        private System.Windows.Forms.Button _login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _pw;
        private System.Windows.Forms.TextBox _un;
        private System.Windows.Forms.TextBox _ipaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _report;
    }
}

