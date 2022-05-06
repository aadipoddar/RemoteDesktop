namespace RemoteDesktop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.yourIPPanel = new System.Windows.Forms.Panel();
            this.youIPLabel = new System.Windows.Forms.Label();
            this.yourIPTextBox = new System.Windows.Forms.TextBox();
            this.yourIPRedPanel = new System.Windows.Forms.Panel();
            this.clientIPPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.clientIPLabel = new System.Windows.Forms.Label();
            this.clientIPTextBox = new System.Windows.Forms.TextBox();
            this.clientIPRedPanel = new System.Windows.Forms.Panel();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.disconnectButton = new MetroFramework.Controls.MetroButton();
            this.rdp = new AxMSTSCLib.AxMsRdpClient11NotSafeForScripting();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.checkConnectionButton = new MetroFramework.Controls.MetroButton();
            this.yourIPPanel.SuspendLayout();
            this.clientIPPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // yourIPPanel
            // 
            this.yourIPPanel.BackColor = System.Drawing.Color.Silver;
            this.yourIPPanel.Controls.Add(this.youIPLabel);
            this.yourIPPanel.Controls.Add(this.yourIPTextBox);
            this.yourIPPanel.Controls.Add(this.yourIPRedPanel);
            this.yourIPPanel.Location = new System.Drawing.Point(23, 63);
            this.yourIPPanel.Name = "yourIPPanel";
            this.yourIPPanel.Size = new System.Drawing.Size(218, 56);
            this.yourIPPanel.TabIndex = 0;
            // 
            // youIPLabel
            // 
            this.youIPLabel.AutoSize = true;
            this.youIPLabel.Location = new System.Drawing.Point(21, 8);
            this.youIPLabel.Name = "youIPLabel";
            this.youIPLabel.Size = new System.Drawing.Size(42, 13);
            this.youIPLabel.TabIndex = 3;
            this.youIPLabel.Text = "Your IP";
            // 
            // yourIPTextBox
            // 
            this.yourIPTextBox.Location = new System.Drawing.Point(20, 27);
            this.yourIPTextBox.Name = "yourIPTextBox";
            this.yourIPTextBox.Size = new System.Drawing.Size(188, 20);
            this.yourIPTextBox.TabIndex = 2;
            // 
            // yourIPRedPanel
            // 
            this.yourIPRedPanel.BackColor = System.Drawing.Color.Red;
            this.yourIPRedPanel.Location = new System.Drawing.Point(3, 3);
            this.yourIPRedPanel.Name = "yourIPRedPanel";
            this.yourIPRedPanel.Size = new System.Drawing.Size(11, 50);
            this.yourIPRedPanel.TabIndex = 1;
            // 
            // clientIPPanel
            // 
            this.clientIPPanel.BackColor = System.Drawing.Color.Silver;
            this.clientIPPanel.Controls.Add(this.passwordLabel);
            this.clientIPPanel.Controls.Add(this.usernameLabel);
            this.clientIPPanel.Controls.Add(this.passwordTextBox);
            this.clientIPPanel.Controls.Add(this.usernameTextBox);
            this.clientIPPanel.Controls.Add(this.clientIPLabel);
            this.clientIPPanel.Controls.Add(this.clientIPTextBox);
            this.clientIPPanel.Controls.Add(this.clientIPRedPanel);
            this.clientIPPanel.Location = new System.Drawing.Point(267, 63);
            this.clientIPPanel.Name = "clientIPPanel";
            this.clientIPPanel.Size = new System.Drawing.Size(607, 56);
            this.clientIPPanel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(406, 8);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(185, 8);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "UserName";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(409, 27);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(188, 27);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(194, 20);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // clientIPLabel
            // 
            this.clientIPLabel.AutoSize = true;
            this.clientIPLabel.Location = new System.Drawing.Point(21, 8);
            this.clientIPLabel.Name = "clientIPLabel";
            this.clientIPLabel.Size = new System.Drawing.Size(46, 13);
            this.clientIPLabel.TabIndex = 3;
            this.clientIPLabel.Text = "Client IP";
            // 
            // clientIPTextBox
            // 
            this.clientIPTextBox.Location = new System.Drawing.Point(20, 27);
            this.clientIPTextBox.Name = "clientIPTextBox";
            this.clientIPTextBox.Size = new System.Drawing.Size(147, 20);
            this.clientIPTextBox.TabIndex = 2;
            this.clientIPTextBox.Leave += new System.EventHandler(this.clientIPTextBox_Leave);
            // 
            // clientIPRedPanel
            // 
            this.clientIPRedPanel.BackColor = System.Drawing.Color.Red;
            this.clientIPRedPanel.Location = new System.Drawing.Point(3, 3);
            this.clientIPRedPanel.Name = "clientIPRedPanel";
            this.clientIPRedPanel.Size = new System.Drawing.Size(11, 50);
            this.clientIPRedPanel.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(893, 63);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(111, 53);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(1026, 63);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(111, 53);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseSelectable = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // rdp
            // 
            this.rdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(23, 134);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(1267, 455);
            this.rdp.TabIndex = 2;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(263, 26);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(0, 24);
            this.clientNameLabel.TabIndex = 5;
            // 
            // checkConnectionButton
            // 
            this.checkConnectionButton.Location = new System.Drawing.Point(1154, 63);
            this.checkConnectionButton.Name = "checkConnectionButton";
            this.checkConnectionButton.Size = new System.Drawing.Size(111, 53);
            this.checkConnectionButton.TabIndex = 6;
            this.checkConnectionButton.Text = "Check Connection";
            this.checkConnectionButton.UseSelectable = true;
            this.checkConnectionButton.Click += new System.EventHandler(this.checkConnectionButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.checkConnectionButton);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rdp);
            this.Controls.Add(this.clientIPPanel);
            this.Controls.Add(this.yourIPPanel);
            this.Name = "Main";
            this.Text = "Remote Desktop";
            this.Load += new System.EventHandler(this.Main_Load);
            this.yourIPPanel.ResumeLayout(false);
            this.yourIPPanel.PerformLayout();
            this.clientIPPanel.ResumeLayout(false);
            this.clientIPPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel yourIPPanel;
        private System.Windows.Forms.Label youIPLabel;
        private System.Windows.Forms.TextBox yourIPTextBox;
        private System.Windows.Forms.Panel yourIPRedPanel;
        private System.Windows.Forms.Panel clientIPPanel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label clientIPLabel;
        private System.Windows.Forms.TextBox clientIPTextBox;
        private System.Windows.Forms.Panel clientIPRedPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private AxMSTSCLib.AxMsRdpClient11NotSafeForScripting rdp;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroButton disconnectButton;
        private System.Windows.Forms.Label clientNameLabel;
        private MetroFramework.Controls.MetroButton checkConnectionButton;
    }
}

