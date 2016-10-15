namespace _4ChanDownloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsDownloaders = new System.Windows.Forms.TabControl();
            this.tabThreads = new System.Windows.Forms.TabPage();
            this.listThreads = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBoard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmThreadsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveThread = new System.Windows.Forms.ToolStripMenuItem();
            this.txtThreadUrl = new System.Windows.Forms.TextBox();
            this.btnAddThread = new System.Windows.Forms.Button();
            this.tabBoards = new System.Windows.Forms.TabPage();
            this.listBoards = new System.Windows.Forms.ListView();
            this.chBBoard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBBoardTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBThreads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoardUrl = new System.Windows.Forms.TextBox();
            this.btAddBoard = new System.Windows.Forms.Button();
            this.cbBoardsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.tabsDownloaders.SuspendLayout();
            this.tabThreads.SuspendLayout();
            this.cmThreadsList.SuspendLayout();
            this.tabBoards.SuspendLayout();
            this.cbBoardsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.btnSettings,
            this.aboutToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(558, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "App";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(61, 20);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabsDownloaders
            // 
            this.tabsDownloaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsDownloaders.Controls.Add(this.tabThreads);
            this.tabsDownloaders.Controls.Add(this.tabBoards);
            this.tabsDownloaders.Location = new System.Drawing.Point(0, 27);
            this.tabsDownloaders.Name = "tabsDownloaders";
            this.tabsDownloaders.SelectedIndex = 0;
            this.tabsDownloaders.Size = new System.Drawing.Size(558, 212);
            this.tabsDownloaders.TabIndex = 2;
            // 
            // tabThreads
            // 
            this.tabThreads.Controls.Add(this.listThreads);
            this.tabThreads.Controls.Add(this.txtThreadUrl);
            this.tabThreads.Controls.Add(this.btnAddThread);
            this.tabThreads.Location = new System.Drawing.Point(4, 22);
            this.tabThreads.Name = "tabThreads";
            this.tabThreads.Padding = new System.Windows.Forms.Padding(3);
            this.tabThreads.Size = new System.Drawing.Size(550, 186);
            this.tabThreads.TabIndex = 0;
            this.tabThreads.Text = "Threads";
            this.tabThreads.UseVisualStyleBackColor = true;
            // 
            // listThreads
            // 
            this.listThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listThreads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chBoard,
            this.chTitle,
            this.chTotalFiles});
            this.listThreads.FullRowSelect = true;
            this.listThreads.GridLines = true;
            this.listThreads.Location = new System.Drawing.Point(9, 33);
            this.listThreads.Name = "listThreads";
            this.listThreads.Size = new System.Drawing.Size(533, 147);
            this.listThreads.TabIndex = 2;
            this.listThreads.UseCompatibleStateImageBehavior = false;
            this.listThreads.View = System.Windows.Forms.View.Details;
            this.listThreads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listThreads_MouseClick);
            // 
            // chID
            // 
            this.chID.Text = "#";
            // 
            // chBoard
            // 
            this.chBoard.Text = "Board";
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 344;
            // 
            // chTotalFiles
            // 
            this.chTotalFiles.Text = "Files";
            // 
            // cmThreadsList
            // 
            this.cmThreadsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveThread});
            this.cmThreadsList.Name = "cmThreadsList";
            this.cmThreadsList.Size = new System.Drawing.Size(118, 26);
            // 
            // btnRemoveThread
            // 
            this.btnRemoveThread.Name = "btnRemoveThread";
            this.btnRemoveThread.Size = new System.Drawing.Size(117, 22);
            this.btnRemoveThread.Text = "Remove";
            this.btnRemoveThread.Click += new System.EventHandler(this.btnRemoveThread_Click);
            // 
            // txtThreadUrl
            // 
            this.txtThreadUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThreadUrl.Location = new System.Drawing.Point(8, 6);
            this.txtThreadUrl.Name = "txtThreadUrl";
            this.txtThreadUrl.Size = new System.Drawing.Size(455, 20);
            this.txtThreadUrl.TabIndex = 1;
            // 
            // btnAddThread
            // 
            this.btnAddThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddThread.Location = new System.Drawing.Point(469, 6);
            this.btnAddThread.Name = "btnAddThread";
            this.btnAddThread.Size = new System.Drawing.Size(75, 23);
            this.btnAddThread.TabIndex = 0;
            this.btnAddThread.Text = "Add";
            this.btnAddThread.UseVisualStyleBackColor = true;
            this.btnAddThread.Click += new System.EventHandler(this.btnAddThread_Click);
            // 
            // tabBoards
            // 
            this.tabBoards.Controls.Add(this.listBoards);
            this.tabBoards.Controls.Add(this.txtBoardUrl);
            this.tabBoards.Controls.Add(this.btAddBoard);
            this.tabBoards.Location = new System.Drawing.Point(4, 22);
            this.tabBoards.Name = "tabBoards";
            this.tabBoards.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoards.Size = new System.Drawing.Size(550, 186);
            this.tabBoards.TabIndex = 1;
            this.tabBoards.Text = "Boards";
            this.tabBoards.UseVisualStyleBackColor = true;
            // 
            // listBoards
            // 
            this.listBoards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBBoard,
            this.chBBoardTitle,
            this.chBThreads});
            this.listBoards.FullRowSelect = true;
            this.listBoards.GridLines = true;
            this.listBoards.Location = new System.Drawing.Point(6, 31);
            this.listBoards.Name = "listBoards";
            this.listBoards.Size = new System.Drawing.Size(536, 147);
            this.listBoards.TabIndex = 4;
            this.listBoards.UseCompatibleStateImageBehavior = false;
            this.listBoards.View = System.Windows.Forms.View.Details;
            this.listBoards.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoards_MouseClick);
            // 
            // chBBoard
            // 
            this.chBBoard.Text = "Board";
            this.chBBoard.Width = 79;
            // 
            // chBBoardTitle
            // 
            this.chBBoardTitle.Text = "Title";
            this.chBBoardTitle.Width = 273;
            // 
            // chBThreads
            // 
            this.chBThreads.Text = "Threads";
            this.chBThreads.Width = 170;
            // 
            // txtBoardUrl
            // 
            this.txtBoardUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoardUrl.Location = new System.Drawing.Point(6, 6);
            this.txtBoardUrl.Name = "txtBoardUrl";
            this.txtBoardUrl.Size = new System.Drawing.Size(455, 20);
            this.txtBoardUrl.TabIndex = 3;
            // 
            // btAddBoard
            // 
            this.btAddBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddBoard.Location = new System.Drawing.Point(467, 6);
            this.btAddBoard.Name = "btAddBoard";
            this.btAddBoard.Size = new System.Drawing.Size(75, 23);
            this.btAddBoard.TabIndex = 2;
            this.btAddBoard.Text = "Add";
            this.btAddBoard.UseVisualStyleBackColor = true;
            this.btAddBoard.Click += new System.EventHandler(this.btAddBoard_Click);
            // 
            // cbBoardsList
            // 
            this.cbBoardsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveBoard});
            this.cbBoardsList.Name = "cmThreadsList";
            this.cbBoardsList.Size = new System.Drawing.Size(118, 26);
            // 
            // btnRemoveBoard
            // 
            this.btnRemoveBoard.Name = "btnRemoveBoard";
            this.btnRemoveBoard.Size = new System.Drawing.Size(152, 22);
            this.btnRemoveBoard.Text = "Remove";
            this.btnRemoveBoard.Click += new System.EventHandler(this.btnRemoveBoard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 239);
            this.Controls.Add(this.tabsDownloaders);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4ChanDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.tabsDownloaders.ResumeLayout(false);
            this.tabThreads.ResumeLayout(false);
            this.tabThreads.PerformLayout();
            this.cmThreadsList.ResumeLayout(false);
            this.tabBoards.ResumeLayout(false);
            this.tabBoards.PerformLayout();
            this.cbBoardsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabsDownloaders;
        private System.Windows.Forms.TabPage tabThreads;
        private System.Windows.Forms.TextBox txtThreadUrl;
        private System.Windows.Forms.Button btnAddThread;
        private System.Windows.Forms.TabPage tabBoards;
        private System.Windows.Forms.ListView listThreads;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chTotalFiles;
        private System.Windows.Forms.ColumnHeader chBoard;
        private System.Windows.Forms.TextBox txtBoardUrl;
        private System.Windows.Forms.Button btAddBoard;
        private System.Windows.Forms.ListView listBoards;
        private System.Windows.Forms.ColumnHeader chBBoard;
        private System.Windows.Forms.ColumnHeader chBBoardTitle;
        private System.Windows.Forms.ColumnHeader chBThreads;
        private System.Windows.Forms.ContextMenuStrip cmThreadsList;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveThread;
        private System.Windows.Forms.ContextMenuStrip cbBoardsList;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveBoard;
    }
}

