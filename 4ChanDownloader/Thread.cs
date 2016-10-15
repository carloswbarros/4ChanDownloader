using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _4ChanDownloader
{
    public class Thread
    {
        private MainForm gui;
        private string url;
        private string board;
        private string id;
        private string title;
        private List<string> downloadedPosts;
        private System.Timers.Timer downloadTimer;
        private int totalFiles;

        public Thread(MainForm gui, string url)
        {
            this.gui = gui;
            this.url = url;
            this.board = "";
            this.id = "";
            this.title = "";
            this.fetchUrlInformation();
            this.downloadedPosts = new List<string>();
            this.totalFiles = 0;

            downloadTimer = new System.Timers.Timer();
            downloadTimer.Elapsed += new ElapsedEventHandler(DownloadTimerEvent);
            downloadTimer.Interval = Properties.Settings.Default.ThreadsTimer;
            downloadTimer.Enabled = false;
        }

        /**
         * Fetch URL Information 
         */
        private void fetchUrlInformation()
        {
            Match match = Regex.Match(this.url, @"boards.4chan.org\/([a-zA-Z0-9]*?)\/thread\/([0-9]*)");
            if (match.Success)
            {
                this.board = match.Groups[1].Value;
                this.id = match.Groups[2].Value;
                this.title = this.id;
            }
        }

        /**
         * Is URL Valid
         */
        public bool isUrlValid()
        {
            return (!string.IsNullOrEmpty(this.board) && !string.IsNullOrEmpty(this.id));
        }

        /**
         * Download the thread once
         */
        public bool download()
        {
            if (!this.isUrlValid()) return false;

            // Create directorys
            Directory.CreateDirectory(this.getOutputDir());

            // Download json thread
            string json = new WebClient().DownloadString("http://a.4cdn.org/" + this.board + "/thread/" + this.id + ".json");
            JObject data = JObject.Parse(json);

            // Update title in the gui
            JToken url_title = data["posts"][0]["semantic_url"];
            if (url_title != null)
            {
                if(this.title != url_title.ToString())
                {
                    this.title = url_title.ToString();
                    this.gui.updateThreadTitle(this.id, this.title);
                }
            }

            // For each post
            foreach (var post in data["posts"])
            {
                string no = post["no"].ToString();

                // If the post wasn't downloaded yet
                if (!this.downloadedPosts.Contains(no))
                {
                    this.downloadedPosts.Add(no);

                    // Download file
                    JToken original_file_name = post["filename"];
                    if (original_file_name != null)
                    {
                        this.totalFiles++;
                        string unique_file_name = post["tim"].ToString() + post["ext"].ToString();
                        this.downloadFile(unique_file_name, original_file_name.ToString());

                        // Update total files in the gui
                        gui.updateThreadTotalFiles(this.id, this.totalFiles);
                    }
                    
                    // Download page
                    if (Properties.Settings.Default.ThreadsDownloadPage)
                    {
                        this.downloadPage();
                    }
                }
            }

            return true;
        }

        /**
         * Watch for new posts and Download them
         */
        public bool watch()
        {
            if (!this.isUrlValid()) return false;

            gui.addThread(this, id, board, title, 0);

            downloadTimer.Enabled = true;

            return true;
        }

        /**
         * Download Timer Event
         */
        private void DownloadTimerEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                this.download();
            }
            catch (WebException ex)
            {
                HttpWebResponse webResponse = (HttpWebResponse)ex.Response;
                if (webResponse != null)
                {
                    if (webResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        gui.updateThreadColor(this.id, Color.Red);
                        downloadTimer.Enabled = false;
                    }
                }
            }
        }

        /**
         * Download File
         */
        private void downloadFile(string file_name, string original_file_name)
        {
            string download_url = "http://i.4cdn.org/"+this.board+"/"+ file_name;
            using (var client = new WebClient())
            {
                client.DownloadFile(download_url, Path.Combine(this.getOutputDir(), original_file_name+"_"+file_name));
            }
        }

        /**
         * Download Page
         */
        private void downloadPage()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(this.url, Path.Combine(this.getOutputDir(), "page.html"));
            }
        }

        /**
         * Get Id
         */
        public string getId()
        {
            return this.id;
        }

        /**
         * Is Alive
         */
        public bool isAlive()
        {
            return downloadTimer.Enabled;
        }

        /**
         * Stop
         */
        public void stop()
        {
            downloadTimer.Enabled = false;
        }

        /**
         * Get Output Dir
         */
        public string getOutputDir()
        {
            return Path.Combine(Properties.Settings.Default.OutputPath, this.board + "\\" + this.id + "\\");
        }

        /**
         * Get Url
         */
        public string getUrl()
        {
            return this.url;
        }
    }
}
