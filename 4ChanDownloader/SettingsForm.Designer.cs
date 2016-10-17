namespace _4ChanDownloader
{
    partial class SettingsForm
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
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSystemTrayClick = new System.Windows.Forms.RadioButton();
            this.rbSystemTrayDoubleClick = new System.Windows.Forms.RadioButton();
            this.cbMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
            this.btnChooseOutputPath = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRemove404Thread = new System.Windows.Forms.CheckBox();
            this.cbSaveThreadsUrls = new System.Windows.Forms.CheckBox();
            this.cbThreadsDownloadPage = new System.Windows.Forms.CheckBox();
            this.nudThreadsTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBoardsMaxThreadsActivate = new System.Windows.Forms.CheckBox();
            this.nudBoardsMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBoardsTimer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.cbProxyUseCredentials = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProxyServer = new System.Windows.Forms.TextBox();
            this.cbUseProxy = new System.Windows.Forms.CheckBox();
            this.btTestMyIpWithProxy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadsTimer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsMaxThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsTimer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output path:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(9, 37);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(393, 20);
            this.txtOutputPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSystemTrayClick);
            this.groupBox1.Controls.Add(this.rbSystemTrayDoubleClick);
            this.groupBox1.Controls.Add(this.cbMinimizeToSystemTray);
            this.groupBox1.Controls.Add(this.btnChooseOutputPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // rbSystemTrayClick
            // 
            this.rbSystemTrayClick.AutoSize = true;
            this.rbSystemTrayClick.Location = new System.Drawing.Point(427, 66);
            this.rbSystemTrayClick.Name = "rbSystemTrayClick";
            this.rbSystemTrayClick.Size = new System.Drawing.Size(48, 17);
            this.rbSystemTrayClick.TabIndex = 5;
            this.rbSystemTrayClick.Text = "Click";
            this.rbSystemTrayClick.UseVisualStyleBackColor = true;
            // 
            // rbSystemTrayDoubleClick
            // 
            this.rbSystemTrayDoubleClick.AutoSize = true;
            this.rbSystemTrayDoubleClick.Checked = true;
            this.rbSystemTrayDoubleClick.Location = new System.Drawing.Point(338, 66);
            this.rbSystemTrayDoubleClick.Name = "rbSystemTrayDoubleClick";
            this.rbSystemTrayDoubleClick.Size = new System.Drawing.Size(85, 17);
            this.rbSystemTrayDoubleClick.TabIndex = 4;
            this.rbSystemTrayDoubleClick.TabStop = true;
            this.rbSystemTrayDoubleClick.Text = "Double Click";
            this.rbSystemTrayDoubleClick.UseVisualStyleBackColor = true;
            // 
            // cbMinimizeToSystemTray
            // 
            this.cbMinimizeToSystemTray.AutoSize = true;
            this.cbMinimizeToSystemTray.Checked = true;
            this.cbMinimizeToSystemTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMinimizeToSystemTray.Location = new System.Drawing.Point(9, 66);
            this.cbMinimizeToSystemTray.Name = "cbMinimizeToSystemTray";
            this.cbMinimizeToSystemTray.Size = new System.Drawing.Size(335, 17);
            this.cbMinimizeToSystemTray.TabIndex = 3;
            this.cbMinimizeToSystemTray.Text = "Minimize to system tray, and open by clicking the system tray with ";
            this.cbMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this.cbMinimizeToSystemTray.CheckedChanged += new System.EventHandler(this.cbMinimizeToSystemTray_CheckedChanged);
            // 
            // btnChooseOutputPath
            // 
            this.btnChooseOutputPath.Location = new System.Drawing.Point(408, 37);
            this.btnChooseOutputPath.Name = "btnChooseOutputPath";
            this.btnChooseOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseOutputPath.TabIndex = 2;
            this.btnChooseOutputPath.Text = "Choose";
            this.btnChooseOutputPath.UseVisualStyleBackColor = true;
            this.btnChooseOutputPath.Click += new System.EventHandler(this.btnChooseOutputPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRemove404Thread);
            this.groupBox2.Controls.Add(this.cbSaveThreadsUrls);
            this.groupBox2.Controls.Add(this.cbThreadsDownloadPage);
            this.groupBox2.Controls.Add(this.nudThreadsTimer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threads";
            // 
            // cbRemove404Thread
            // 
            this.cbRemove404Thread.AutoSize = true;
            this.cbRemove404Thread.Location = new System.Drawing.Point(12, 108);
            this.cbRemove404Thread.Name = "cbRemove404Thread";
            this.cbRemove404Thread.Size = new System.Drawing.Size(461, 17);
            this.cbRemove404Thread.TabIndex = 6;
            this.cbRemove404Thread.Text = "Auto remove 404 thread from list (if disabled the background of the thread will c" +
    "hange to red)";
            this.cbRemove404Thread.UseVisualStyleBackColor = true;
            // 
            // cbSaveThreadsUrls
            // 
            this.cbSaveThreadsUrls.AutoSize = true;
            this.cbSaveThreadsUrls.Checked = true;
            this.cbSaveThreadsUrls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveThreadsUrls.Location = new System.Drawing.Point(12, 85);
            this.cbSaveThreadsUrls.Name = "cbSaveThreadsUrls";
            this.cbSaveThreadsUrls.Size = new System.Drawing.Size(81, 17);
            this.cbSaveThreadsUrls.TabIndex = 5;
            this.cbSaveThreadsUrls.Text = "Save URLs";
            this.cbSaveThreadsUrls.UseVisualStyleBackColor = true;
            // 
            // cbThreadsDownloadPage
            // 
            this.cbThreadsDownloadPage.AutoSize = true;
            this.cbThreadsDownloadPage.Checked = true;
            this.cbThreadsDownloadPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThreadsDownloadPage.Location = new System.Drawing.Point(12, 62);
            this.cbThreadsDownloadPage.Name = "cbThreadsDownloadPage";
            this.cbThreadsDownloadPage.Size = new System.Drawing.Size(101, 17);
            this.cbThreadsDownloadPage.TabIndex = 4;
            this.cbThreadsDownloadPage.Text = "Download page";
            this.cbThreadsDownloadPage.UseVisualStyleBackColor = true;
            // 
            // nudThreadsTimer
            // 
            this.nudThreadsTimer.Location = new System.Drawing.Point(12, 36);
            this.nudThreadsTimer.Name = "nudThreadsTimer";
            this.nudThreadsTimer.Size = new System.Drawing.Size(471, 20);
            this.nudThreadsTimer.TabIndex = 2;
            this.nudThreadsTimer.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Timer (seconds):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBoardsMaxThreadsActivate);
            this.groupBox3.Controls.Add(this.nudBoardsMaxThreads);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudBoardsTimer);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 107);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boards";
            // 
            // cbBoardsMaxThreadsActivate
            // 
            this.cbBoardsMaxThreadsActivate.AutoSize = true;
            this.cbBoardsMaxThreadsActivate.Checked = true;
            this.cbBoardsMaxThreadsActivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoardsMaxThreadsActivate.Location = new System.Drawing.Point(418, 78);
            this.cbBoardsMaxThreadsActivate.Name = "cbBoardsMaxThreadsActivate";
            this.cbBoardsMaxThreadsActivate.Size = new System.Drawing.Size(65, 17);
            this.cbBoardsMaxThreadsActivate.TabIndex = 5;
            this.cbBoardsMaxThreadsActivate.Text = "Activate";
            this.cbBoardsMaxThreadsActivate.UseVisualStyleBackColor = true;
            this.cbBoardsMaxThreadsActivate.CheckedChanged += new System.EventHandler(this.cbBoardsMaxThreadsActivate_CheckedChanged);
            // 
            // nudBoardsMaxThreads
            // 
            this.nudBoardsMaxThreads.Location = new System.Drawing.Point(12, 77);
            this.nudBoardsMaxThreads.Name = "nudBoardsMaxThreads";
            this.nudBoardsMaxThreads.Size = new System.Drawing.Size(400, 20);
            this.nudBoardsMaxThreads.TabIndex = 4;
            this.nudBoardsMaxThreads.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Get only the first N threads (Watching all threads from a board is too much):";
            // 
            // nudBoardsTimer
            // 
            this.nudBoardsTimer.Location = new System.Drawing.Point(12, 36);
            this.nudBoardsTimer.Name = "nudBoardsTimer";
            this.nudBoardsTimer.Size = new System.Drawing.Size(471, 20);
            this.nudBoardsTimer.TabIndex = 2;
            this.nudBoardsTimer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Timer (seconds):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTestMyIpWithProxy);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtProxyPassword);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtProxyUsername);
            this.groupBox4.Controls.Add(this.cbProxyUseCredentials);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtProxyServer);
            this.groupBox4.Controls.Add(this.cbUseProxy);
            this.groupBox4.Location = new System.Drawing.Point(12, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 149);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proxy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password:";
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(253, 118);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.PasswordChar = '*';
            this.txtProxyPassword.Size = new System.Drawing.Size(230, 20);
            this.txtProxyPassword.TabIndex = 6;
            this.txtProxyPassword.Text = "secret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // txtProxyUsername
            // 
            this.txtProxyUsername.Location = new System.Drawing.Point(12, 118);
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.Size = new System.Drawing.Size(227, 20);
            this.txtProxyUsername.TabIndex = 4;
            this.txtProxyUsername.Text = "example";
            // 
            // cbProxyUseCredentials
            // 
            this.cbProxyUseCredentials.AutoSize = true;
            this.cbProxyUseCredentials.Location = new System.Drawing.Point(12, 82);
            this.cbProxyUseCredentials.Name = "cbProxyUseCredentials";
            this.cbProxyUseCredentials.Size = new System.Drawing.Size(99, 17);
            this.cbProxyUseCredentials.TabIndex = 3;
            this.cbProxyUseCredentials.Text = "Use credentials";
            this.cbProxyUseCredentials.UseVisualStyleBackColor = true;
            this.cbProxyUseCredentials.CheckedChanged += new System.EventHandler(this.cbProxyUseCredentials_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Server:";
            // 
            // txtProxyServer
            // 
            this.txtProxyServer.Location = new System.Drawing.Point(12, 56);
            this.txtProxyServer.Name = "txtProxyServer";
            this.txtProxyServer.Size = new System.Drawing.Size(471, 20);
            this.txtProxyServer.TabIndex = 1;
            this.txtProxyServer.Text = "127.0.0.1:8080";
            // 
            // cbUseProxy
            // 
            this.cbUseProxy.AutoSize = true;
            this.cbUseProxy.Location = new System.Drawing.Point(12, 20);
            this.cbUseProxy.Name = "cbUseProxy";
            this.cbUseProxy.Size = new System.Drawing.Size(73, 17);
            this.cbUseProxy.TabIndex = 0;
            this.cbUseProxy.Text = "Use proxy";
            this.cbUseProxy.UseVisualStyleBackColor = true;
            this.cbUseProxy.CheckedChanged += new System.EventHandler(this.cbUseProxy_CheckedChanged);
            // 
            // btTestMyIpWithProxy
            // 
            this.btTestMyIpWithProxy.Location = new System.Drawing.Point(338, 16);
            this.btTestMyIpWithProxy.Name = "btTestMyIpWithProxy";
            this.btTestMyIpWithProxy.Size = new System.Drawing.Size(145, 23);
            this.btTestMyIpWithProxy.TabIndex = 8;
            this.btTestMyIpWithProxy.Text = "Test my ip with the proxy";
            this.btTestMyIpWithProxy.UseVisualStyleBackColor = true;
            this.btTestMyIpWithProxy.Click += new System.EventHandler(this.btTestMyIpWithProxy_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadsTimer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsMaxThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsTimer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseOutputPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudThreadsTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbThreadsDownloadPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudBoardsTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBoardsMaxThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbBoardsMaxThreadsActivate;
        private System.Windows.Forms.CheckBox cbSaveThreadsUrls;
        private System.Windows.Forms.CheckBox cbMinimizeToSystemTray;
        private System.Windows.Forms.RadioButton rbSystemTrayClick;
        private System.Windows.Forms.RadioButton rbSystemTrayDoubleClick;
        private System.Windows.Forms.CheckBox cbRemove404Thread;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbUseProxy;
        private System.Windows.Forms.CheckBox cbProxyUseCredentials;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProxyServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.Button btTestMyIpWithProxy;
    }
}