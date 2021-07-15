using Accord.Video.FFMPEG;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTVClient
{
    public partial class MainForm : Form
    {
        private List<CameraFeed> _feeds;
        private Dictionary<int, PictureBox> _controlDict;
        private Timer _feedUpdateTimer;

        private const string RegKeyName = "CCTVClient";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _feeds = new List<CameraFeed>()
            {
                new CameraFeed(1, "Front Path", "rtsp://admin:@192.168.0.58/user=admin_password=tlJwpbo6_channel=1_stream=1.sdp"),
                new CameraFeed(2, "Front Drive", "rtsp://admin:@192.168.0.58/user=admin_password=tlJwpbo6_channel=4_stream=1.sdp"),
                new CameraFeed(3, "Back Patio", "rtsp://admin:@192.168.0.58/user=admin_password=tlJwpbo6_channel=3_stream=1.sdp"),
                new CameraFeed(4, "Back Grass", "rtsp://admin:@192.168.0.58/user=admin_password=tlJwpbo6_channel=2_stream=1.sdp"),
            };

            _controlDict = new Dictionary<int, PictureBox>()
            {
                {1, cam1 },
                {2, cam2 },
                {3, cam3 },
                {4, cam4 },
            };

            _feedUpdateTimer = new Timer()
            {
                Interval = 1
            };

            Start();
            PopulateVlcButtons();
            chkStartup.Checked = IsEnabledForStartup();
        }

        private void UpdateFrames(object x, EventArgs y)
        {
            foreach(var feed in _feeds)
            {
                if (!feed.IsReady) continue;
                var control = _controlDict[feed.Id];
                var frame = feed.GetLatestFrame();
                control.Image = frame;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            _feedUpdateTimer.Stop();
            foreach(var feed in _feeds)
            {
                Task.Run(() => feed.CloseFeed());
            }

            foreach(var kvp in _controlDict)
            {
                kvp.Value.Image = null;
            }
            btnStart.Enabled = true;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            foreach (var feed in _feeds)
            {
                Task.Run(() => feed.OpenFeedAsync());
            }

            _feedUpdateTimer.Tick += UpdateFrames;
            _feedUpdateTimer.Start();
            btnStop.Enabled = true;
        }

        private void PopulateVlcButtons()
        {
            foreach(var feed in _feeds)
            {
                var feedButton = new Button
                {
                    Text = feed.Name
                };

                feedButton.Click += (x, y) =>
                {
                    Process.Start(@"C:\Program Files\VideoLAN\VLC\vlc.exe", feed.Url);
                };

                flowVlcButtons.Controls.Add(feedButton);
            }
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            var rk = GetStartupKey();

            if (chkStartup.Checked)
                rk.SetValue(RegKeyName, Application.ExecutablePath);
            else
                rk.DeleteValue(RegKeyName, false);
        }

        private bool IsEnabledForStartup()
        {
            var key = GetStartupKey();
            return key.GetValue(RegKeyName) != null;
        }

        private RegistryKey GetStartupKey()
        {
            var rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            return rk;
        }
    }
}
