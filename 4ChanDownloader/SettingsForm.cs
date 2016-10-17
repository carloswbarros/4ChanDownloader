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
            cbRemove404Thread.Checked = Properties.Settings.Default.Remove404Thread;
            cbUseProxy.Checked = Properties.Settings.Default.UseProxy;
            txtProxyServer.Text = Properties.Settings.Default.ProxyServer;
            cbProxyUseCredentials.Checked = Properties.Settings.Default.ProxyUseCredentials;
            txtProxyUsername.Text = Properties.Settings.Default.ProxyUsername;
            txtProxyPassword.Text = Properties.Settings.Default.ProxyPassword;

            cbBoardsMaxThreadsActivate_CheckedChanged(null, null);
            cbMinimizeToSystemTray_CheckedChanged(null, null);
            cbUseProxy_CheckedChanged(null, null);
            cbProxyUseCredentials_CheckedChanged(null, null);
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
            Properties.Settings.Default.Remove404Thread = cbRemove404Thread.Checked;
            Properties.Settings.Default.UseProxy = cbUseProxy.Checked;
            Properties.Settings.Default.ProxyServer = txtProxyServer.Text;
            Properties.Settings.Default.ProxyUseCredentials = cbProxyUseCredentials.Checked;
            Properties.Settings.Default.ProxyUsername = txtProxyUsername.Text;
            Properties.Settings.Default.ProxyPassword = txtProxyPassword.Text;

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

        /**
         * Use Proxy (Check Changed)
         */
        private void cbUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseProxy.Checked)
            {
                txtProxyServer.Enabled = true;
                cbProxyUseCredentials.Enabled = true;
                txtProxyUsername.Enabled = true;
                txtProxyPassword.Enabled = true;
            }
            else
            {
                txtProxyServer.Enabled = false;
                cbProxyUseCredentials.Enabled = false;
                txtProxyUsername.Enabled = false;
                txtProxyPassword.Enabled = false;
            }

            cbProxyUseCredentials_CheckedChanged(null, null);
        }

        /**
         * Use Proxy Credentials (Check Changed)
         */
        private void cbProxyUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProxyUseCredentials.Checked)
            {
                txtProxyUsername.Enabled = true;
                txtProxyPassword.Enabled = true;
            }
            else
            {
                txtProxyUsername.Enabled = false;
                txtProxyPassword.Enabled = false;
            }
        }

        /**
        * Test Proxy My IP
        */
        private void btTestMyIpWithProxy_Click(object sender, EventArgs e)
        {
            // Save settings
            Properties.Settings.Default.Save();

            try
            {
                using (var client = new System.Net.WebClient())
                {
                    if (Properties.Settings.Default.UseProxy)
                    {
                        client.Proxy = Helper.getProxy();
                    }

                    MessageBox.Show("My IP with the proxy is: " + client.DownloadString("http://bot.whatismyipaddress.com/"), "My IP");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something might be wrong with the proxy, try another one.", "Error connecting");
            }
        }
    }
}
