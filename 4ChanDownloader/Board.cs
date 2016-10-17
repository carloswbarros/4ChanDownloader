using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _4ChanDownloader
{
    public class Board
    {
        private MainForm gui;
        private string boardTag;
        private List<Thread> activeThreads;
        private System.Timers.Timer downloadTimer;
        private ListViewItem listViewItem;

        public Board(MainForm gui, string boardTag)
        {
            this.gui = gui;
            this.boardTag = boardTag;
            this.activeThreads = new List<Thread>();
            this.listViewItem = null;

            downloadTimer = new System.Timers.Timer();
            downloadTimer.Elapsed += new ElapsedEventHandler(DownloadTimerEvent);
            downloadTimer.Interval = Properties.Settings.Default.BoardsTimer;
            downloadTimer.Enabled = false;
        }

        /**
         * Get Board Threads
         */
        private List<Thread> getThreads()
        {
            List<Thread> rThreads = new List<Thread>();

            WebClient client = new WebClient();
            if (Properties.Settings.Default.UseProxy)
            {
                client.Proxy = Helper.getProxy();
            }
            string json = client.DownloadString("http://a.4cdn.org/" + this.boardTag + "/catalog.json");
            JArray pages = JArray.Parse(json);

            int max_threads = Properties.Settings.Default.BoardsMaxThreads;
            int total_threads = 0;

            foreach (var page in pages)
            {
                foreach (var thread in page["threads"])
                {   
                    // Limit threads to be watched from a board
                    total_threads++;
                    if (total_threads >= max_threads && Properties.Settings.Default.BoardsMaxThreadsActive)
                    {
                        return rThreads;
                    }
                    
                    string thread_id = thread["no"].ToString();

                    if (this.activeThreads.FindIndex(t => t.getId() == thread_id) < 0)
                    {
                        string thread_url = "http://boards.4chan.org/" + this.boardTag + "/thread/" + thread_id;
                        Thread rThread = new Thread(this.gui, thread_url);
                        rThreads.Add(rThread);
                        this.activeThreads.Add(rThread);
                    }
                }
            }

            return rThreads;
        }

        /**
         * Watch Board and Download each Thread
         */
        public bool watch()
        {
            this.listViewItem = this.gui.addBoard(this, this.boardTag, this.boardTag, 0);

            if (this.listViewItem == null)
            {
                return false;
            }

            downloadTimer.Enabled = true;

            return true;
        }

        /**
         * Download Timer Event
         */
        private void DownloadTimerEvent(object source, ElapsedEventArgs e)
        {
            List<Thread> threads = this.getThreads();
            foreach (Thread thread in threads)
            {
                thread.watch();
            }
        }

        /**
         * Stop
         */
        public void stop()
        {
            downloadTimer.Enabled = false;
        }

        /**
         * Get Id
         */
        public string getId()
        {
            return this.boardTag;
        }

        /**
         * Is Alive
         */
        public bool isAlive()
        {
            return downloadTimer.Enabled;
        }
    }
}
