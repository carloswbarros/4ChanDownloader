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
    public partial class MainForm : Form
    {
        private List<Thread> activeThreads;
        private List<Board> activeBoards;

        public MainForm()
        {
            InitializeComponent();
            activeThreads = new List<Thread>();
            activeBoards = new List<Board>();
        }

        /**
         * Exit Button
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Add Thread Button
         */
        private void btnAddThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(this, txtThreadUrl.Text);

            bool watching = thread.watch();

            if (!watching)
            {
                MessageBox.Show("It wasn't possible to download the thread.");
                activeThreads.Remove(thread);
            }
            txtThreadUrl.Text = "";
        }

        /**
         * Add Thread to the List
         */
        public void addThread(Thread thread, string id, string board, string title, int files)
        {
            activeThreads.Add(thread);
            ListViewItem item = new ListViewItem(new string[]{
                id,
                board,
                title,
                files.ToString()
            });
            item.Name = id;
            item.BackColor = Color.Green;

            if (listThreads.InvokeRequired)
            {
                listBoards.Invoke(new MethodInvoker(delegate
                {
                    listThreads.Items.Add(item);
                }));
            }
            else
            {
                listThreads.Items.Add(item);
            }
        }

        /**
         * Add Board to the List
         */
        public void addBoard(Board board, string boardTag, string title, int threads)
        {
            activeBoards.Add(board);
            ListViewItem item = new ListViewItem(new string[]{
                boardTag,
                title,
                threads.ToString()
            });
            item.Name = boardTag;

            if (listBoards.InvokeRequired)
            {
                listBoards.Invoke(new MethodInvoker(delegate
                {
                    listBoards.Items.Add(item);
                }));
            }
            else
            {
                listBoards.Items.Add(item);
            }
        }

        /**
         * Update Thread Title
         */
        public void updateThreadTitle(string id, string title)
        {
            if (listThreads.InvokeRequired)
            {
                listThreads.Invoke(new MethodInvoker(delegate
                {
                    ListViewItem item = listThreads.Items.Find(id, false)[0];
                    item.SubItems[2].Text = title;

                }));
            }
            else
            {
                ListViewItem item = listThreads.Items.Find(id, false)[0];
                item.SubItems[2].Text = title;
            }
        }

        /**
         * Update Thread Total Files
         */
        public void updateThreadTotalFiles(string id, int totalFiles)
        {
            if (listThreads.InvokeRequired)
            {
                listThreads.Invoke(new MethodInvoker(delegate
                {
                    ListViewItem item = listThreads.Items.Find(id, false)[0];
                    item.SubItems[3].Text = totalFiles.ToString();

                }));
            }
            else
            {
                ListViewItem item = listThreads.Items.Find(id, false)[0];
                item.SubItems[3].Text = totalFiles.ToString();
            }
        }

        /**
         * Update Thread Color
         */
        public void updateThreadColor(string id, Color color)
        {
            if (listThreads.InvokeRequired)
            {
                listThreads.Invoke(new MethodInvoker(delegate
                {
                    ListViewItem[] items = listThreads.Items.Find(id, false);
                    if (items.Count() > 0)
                    {
                        ListViewItem item = items[0];
                        item.BackColor = color;
                    }
                }));
            }
            else
            {
                ListViewItem[] items = listThreads.Items.Find(id, false);
                if (items.Count() > 0)
                {
                    ListViewItem item = items[0];
                    item.BackColor = color;
                }
            }
        }

        /**
         * Add Board
         */
        private void btAddBoard_Click(object sender, EventArgs e)
        {
            // TODO: check if is a tag or a url

            Board board = new Board(this, txtBoardUrl.Text);

            bool watching = board.watch();

            txtBoardUrl.Text = "";
        }

        /**
         * Show Settings Form
         */
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        /**
         * Form First Time Shown
         */
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // If is the first time, the show the settings form
            if (Properties.Settings.Default.FirstTime == true)
            {
                Properties.Settings.Default.FirstTime = false;
                SettingsForm sf = new SettingsForm();
                sf.Show();
            }

            // Add the saved threads if enabled
            if (Properties.Settings.Default.SaveThreadsUrls)
            {
                if (Properties.Settings.Default.ThreadsUrls != null)
                {
                    foreach (string url in Properties.Settings.Default.ThreadsUrls)
                    {
                        Thread thread = new Thread(this, url);
                        thread.watch();
                    }
                }
            }
        }

        /**
         * Remove Thread (Context Menu)
         */
        private void btnRemoveThread_Click(object sender, EventArgs e)
        {
            if (listThreads.SelectedItems.Count > 0)
            {
                foreach (ListViewItem threadItem in listThreads.SelectedItems)
                {
                    Thread thread = activeThreads.Find(t => t.getId() == threadItem.Name);
                    this.removeThread(thread, threadItem);
                    
                }
            }
        }

        /**
         * Remove Thread From Active List
         */
        public void removeThread(Thread thread, ListViewItem item = null)
        {
            if (item == null)
            {
                if (listThreads.InvokeRequired)
                {
                    listThreads.Invoke(new MethodInvoker(delegate
                    {
                        item = listThreads.Items.Find(thread.getId(), false)[0];

                    }));
                }
                else
                {
                    item = listThreads.Items.Find(thread.getId(), false)[0];
                }
            }

            if (listThreads.InvokeRequired)
            {
                listThreads.Invoke(new MethodInvoker(delegate
                {
                    item.Remove();

                }));
            }
            else
            {
                item.Remove();
            }
            
            thread.stop();
            this.activeThreads.Remove(thread);
            thread = null;
        }

        /**
         * Threads List Mouse Click
         * This is used to only allow the context menu to work in the rows and not the columns
         */
        private void listThreads_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    cmThreadsList.Show(listView, e.Location);
                }
            }
        }

        /**
         * Remove Board (Context Menu)
         */
        private void btnRemoveBoard_Click(object sender, EventArgs e)
        {
            if (listBoards.SelectedItems.Count > 0)
            {
                foreach (ListViewItem boardItem in listBoards.SelectedItems)
                {
                    Board board = activeBoards.Find(b => b.getId() == boardItem.Name);
                    boardItem.Remove();
                    board.stop();
                    this.activeBoards.Remove(board);
                    board = null;
                }
            }
        }

        /**
         * Boards List Mouse Click
         * This is used to only allow the context menu to work in the rows and not the columns
         */
        private void listBoards_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    cbBoardsList.Show(listView, e.Location);
                }
            }
        }

        /**
         * Form Closing
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save threads urls
            Properties.Settings.Default.ThreadsUrls = new System.Collections.Specialized.StringCollection();
            foreach (Thread thread in this.activeThreads)
            {
                Properties.Settings.Default.ThreadsUrls.Add(thread.getUrl());
            }

            // Save settings
            Properties.Settings.Default.Save();
        }

        /**
         * Show About Message
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4ChanDownloader created by carloswbarros"+Environment.NewLine+ "https://github.com/carloswbarros/4ChanDownloader", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * Form Resize
         */
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Hide to the system tray (if enabled)
            if (Properties.Settings.Default.MinimizeToSystemTray)
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    systemTrayNotify.Visible = true;
                    this.Hide();
                }
                else if (FormWindowState.Normal == this.WindowState)
                {
                    systemTrayNotify.Visible = false;
                }
            }
        }

        /**
         * System Tray Notify Double Click
         */
        private void systemTrayNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.SystemTrayDoubleClick)
            {
                this.Show();
                systemTrayNotify.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        /**
         * System Tray Notify Mouse Click
         */
        private void systemTrayNotify_MouseClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.SystemTrayDoubleClick == false)
            {
                this.Show();
                systemTrayNotify.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
