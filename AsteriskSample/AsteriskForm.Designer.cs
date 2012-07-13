namespace AsteriskSample
{
    partial class AsteriskForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.credentialGroup = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AsteriskPassword = new System.Windows.Forms.TextBox();
            this.AsteriskUsername = new System.Windows.Forms.TextBox();
            this.AsteriskPort = new System.Windows.Forms.TextBox();
            this.AsteriskHost = new System.Windows.Forms.TextBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.StartCallButton = new System.Windows.Forms.Button();
            this.AsteriskLogs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CallerID = new System.Windows.Forms.TextBox();
            this.Caller1 = new System.Windows.Forms.TextBox();
            this.EndCallButton = new System.Windows.Forms.Button();
            this.Caller2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.credentialGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.credentialGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.controlGroup);
            this.splitContainer1.Size = new System.Drawing.Size(541, 422);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // credentialGroup
            // 
            this.credentialGroup.Controls.Add(this.submitBtn);
            this.credentialGroup.Controls.Add(this.label4);
            this.credentialGroup.Controls.Add(this.label3);
            this.credentialGroup.Controls.Add(this.label2);
            this.credentialGroup.Controls.Add(this.label1);
            this.credentialGroup.Controls.Add(this.AsteriskPassword);
            this.credentialGroup.Controls.Add(this.AsteriskUsername);
            this.credentialGroup.Controls.Add(this.AsteriskPort);
            this.credentialGroup.Controls.Add(this.AsteriskHost);
            this.credentialGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.credentialGroup.Location = new System.Drawing.Point(0, 0);
            this.credentialGroup.Name = "credentialGroup";
            this.credentialGroup.Size = new System.Drawing.Size(179, 422);
            this.credentialGroup.TabIndex = 0;
            this.credentialGroup.TabStop = false;
            this.credentialGroup.Text = "Elastix Credentials";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(93, 239);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // AsteriskPassword
            // 
            this.AsteriskPassword.Location = new System.Drawing.Point(6, 213);
            this.AsteriskPassword.Name = "AsteriskPassword";
            this.AsteriskPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsteriskPassword.Size = new System.Drawing.Size(162, 20);
            this.AsteriskPassword.TabIndex = 3;
            this.AsteriskPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AsteriskPassword.UseSystemPasswordChar = true;
            // 
            // AsteriskUsername
            // 
            this.AsteriskUsername.Location = new System.Drawing.Point(6, 159);
            this.AsteriskUsername.Name = "AsteriskUsername";
            this.AsteriskUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsteriskUsername.Size = new System.Drawing.Size(162, 20);
            this.AsteriskUsername.TabIndex = 2;
            this.AsteriskUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AsteriskPort
            // 
            this.AsteriskPort.Location = new System.Drawing.Point(6, 109);
            this.AsteriskPort.Name = "AsteriskPort";
            this.AsteriskPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsteriskPort.Size = new System.Drawing.Size(162, 20);
            this.AsteriskPort.TabIndex = 1;
            this.AsteriskPort.Text = "5038";
            this.AsteriskPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AsteriskHost
            // 
            this.AsteriskHost.Location = new System.Drawing.Point(6, 60);
            this.AsteriskHost.Name = "AsteriskHost";
            this.AsteriskHost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsteriskHost.Size = new System.Drawing.Size(162, 20);
            this.AsteriskHost.TabIndex = 0;
            this.AsteriskHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.EndCallButton);
            this.controlGroup.Controls.Add(this.StartCallButton);
            this.controlGroup.Controls.Add(this.AsteriskLogs);
            this.controlGroup.Controls.Add(this.label6);
            this.controlGroup.Controls.Add(this.label7);
            this.controlGroup.Controls.Add(this.label5);
            this.controlGroup.Controls.Add(this.Caller2);
            this.controlGroup.Controls.Add(this.CallerID);
            this.controlGroup.Controls.Add(this.Caller1);
            this.controlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlGroup.Location = new System.Drawing.Point(0, 0);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(358, 422);
            this.controlGroup.TabIndex = 0;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Controls";
            // 
            // StartCallButton
            // 
            this.StartCallButton.Location = new System.Drawing.Point(73, 132);
            this.StartCallButton.Name = "StartCallButton";
            this.StartCallButton.Size = new System.Drawing.Size(75, 23);
            this.StartCallButton.TabIndex = 3;
            this.StartCallButton.Text = "Start Call";
            this.StartCallButton.UseVisualStyleBackColor = true;
            this.StartCallButton.Click += new System.EventHandler(this.StartCallButton_Click);
            // 
            // AsteriskLogs
            // 
            this.AsteriskLogs.BackColor = System.Drawing.Color.Black;
            this.AsteriskLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsteriskLogs.ForeColor = System.Drawing.Color.Lime;
            this.AsteriskLogs.Location = new System.Drawing.Point(9, 161);
            this.AsteriskLogs.Name = "AsteriskLogs";
            this.AsteriskLogs.Size = new System.Drawing.Size(343, 251);
            this.AsteriskLogs.TabIndex = 3;
            this.AsteriskLogs.TabStop = false;
            this.AsteriskLogs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Caller number 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Caller ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Caller number 1";
            // 
            // CallerID
            // 
            this.CallerID.Location = new System.Drawing.Point(104, 36);
            this.CallerID.Name = "CallerID";
            this.CallerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CallerID.Size = new System.Drawing.Size(242, 20);
            this.CallerID.TabIndex = 1;
            this.CallerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Caller1
            // 
            this.Caller1.Location = new System.Drawing.Point(104, 70);
            this.Caller1.Name = "Caller1";
            this.Caller1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Caller1.Size = new System.Drawing.Size(242, 20);
            this.Caller1.TabIndex = 2;
            this.Caller1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EndCallButton
            // 
            this.EndCallButton.Enabled = false;
            this.EndCallButton.Location = new System.Drawing.Point(204, 132);
            this.EndCallButton.Name = "EndCallButton";
            this.EndCallButton.Size = new System.Drawing.Size(75, 23);
            this.EndCallButton.TabIndex = 3;
            this.EndCallButton.Text = "End Call";
            this.EndCallButton.UseVisualStyleBackColor = true;
            this.EndCallButton.Click += new System.EventHandler(this.EndCallButton_Click);
            // 
            // Caller2
            // 
            this.Caller2.Location = new System.Drawing.Point(104, 106);
            this.Caller2.Name = "Caller2";
            this.Caller2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Caller2.Size = new System.Drawing.Size(242, 20);
            this.Caller2.TabIndex = 3;
            this.Caller2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AsteriskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 422);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AsteriskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asterisk Main Form";
            this.Load += new System.EventHandler(this.AsteriskForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.credentialGroup.ResumeLayout(false);
            this.credentialGroup.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.controlGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox credentialGroup;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AsteriskPassword;
        private System.Windows.Forms.TextBox AsteriskUsername;
        private System.Windows.Forms.TextBox AsteriskPort;
        private System.Windows.Forms.TextBox AsteriskHost;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Caller1;
        private System.Windows.Forms.RichTextBox AsteriskLogs;
        private System.Windows.Forms.Button StartCallButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CallerID;
        private System.Windows.Forms.Button EndCallButton;
        private System.Windows.Forms.TextBox Caller2;
    }
}

