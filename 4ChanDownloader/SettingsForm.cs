using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ChanDownloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        /**
         * Form load
         */
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.OutputPath))
            {
                Properties.Settings.Default.OutputPath = AppDomain.CurrentDomain.BaseDirectory;
            }

            txtOutputPath.Text = Properties.Settings.Default.OutputPath;
            nudThreadsTimer.Value = Properties.Settings.Default.ThreadsTimer;
            cbThreadsDownloadPage.Checked = Properties.Settings.Default.ThreadsDownloadPage;
            nudBoardsTimer.Value = Properties.Settings.Default.BoardsTimer;
            nudBoardsMaxThreads.Value = Properties.Settings.Default.BoardsMaxThreads;
            cbBoardsMaxThreadsActivate.Checked = Properties.Settings.Default.BoardsMaxThreadsActive;
            cbSaveThreadsUrls.Checked = Properties.Settings.Default.SaveThreadsUrls;
            cbMinimizeToSystemTray.Checked = Properties.Settings.Default.MinimizeToSystemTray;
            rbSystemTrayDoubleClick.Checked = Properties.Settings.Default.SystemTrayDoubleClick;
            rbSystemTrayClick.Checked = !Properties.Settings.Default.SystemTrayDoubleClick;
        }

        /**
         * Form closing
         */
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OutputPath = txtOutputPath.Text;
            Properties.Settings.Default.ThreadsTimer = (int) nudThreadsTimer.Value;
            Properties.Settings.Default.ThreadsDownloadPage = cbThreadsDownloadPage.Checked;
            Properties.Settings.Default.BoardsTimer = (int) nudBoardsTimer.Value;
            Properties.Settings.Default.BoardsMaxThreads = (int) nudBoardsMaxThreads.Value;
            Properties.Settings.Default.BoardsMaxThreadsActive = cbBoardsMaxThreadsActivate.Checked;
            Properties.Settings.Default.SaveThreadsUrls = cbSaveThreadsUrls.Checked;
            Properties.Settings.Default.MinimizeToSystemTray = cbMinimizeToSystemTray.Checked;
            Properties.Settings.Default.SystemTrayDoubleClick = rbSystemTrayDoubleClick.Checked;

            // Save settings
            Properties.Settings.Default.Save();
        }

        /**
         * Choose output path
         */
        private void btnChooseOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtOutputPath.Text = fbd.SelectedPath;
            }
        }

        /**
         * Boards Max Threads Activate Changed
         */
        private void cbBoardsMaxThreadsActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBoardsMaxThreadsActivate.Checked == false)
            {
                nudBoardsMaxThreads.Enabled = false;
            }
            else
            {
                nudBoardsMaxThreads.Enabled = true;
            }
        }

        /**
         * Minimize to the system tray (Check Changed)
         */
        private void cbMinimizeToSystemTray_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMinimizeToSystemTray.Checked)
            {
                rbSystemTrayClick.Enabled = true;
                rbSystemTrayDoubleClick.Enabled = true;
            }
            else
            {
                rbSystemTrayClick.Enabled = false;
                rbSystemTrayDoubleClick.Enabled = false;
            }
        }
    }
}
