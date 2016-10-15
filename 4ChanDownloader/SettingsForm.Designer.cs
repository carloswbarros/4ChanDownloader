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
            this.btnChooseOutputPath = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbThreadsDownloadPage = new System.Windows.Forms.CheckBox();
            this.nudThreadsTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBoardsMaxThreadsActivate = new System.Windows.Forms.CheckBox();
            this.nudBoardsMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBoardsTimer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSaveThreadsUrls = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadsTimer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsMaxThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardsTimer)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnChooseOutputPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
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
            this.groupBox2.Controls.Add(this.cbSaveThreadsUrls);
            this.groupBox2.Controls.Add(this.cbThreadsDownloadPage);
            this.groupBox2.Controls.Add(this.nudThreadsTimer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threads";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 321);
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
    }
}