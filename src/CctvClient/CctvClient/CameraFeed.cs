using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTVClient
{
    public class CameraFeed
    {
        private readonly VideoFileReader _reader;
        
        public int Id { get; private set; }
        public string Url { get; private set; }
        public string Name { get; private set; }

        public bool IsReady { get; private set; }
        
        public CameraFeed(int id, string name, string url)
        {
            Id = id;
            Url = url;
            Name = name;
            _reader = new VideoFileReader();
        }

        public async Task OpenFeedAsync()
        {
            await Task.Run(() => _reader.Open(Url));
            Debug.WriteLine($"Feed {Name} opened");
            IsReady = true;
        }

        public async Task<Bitmap> GetLatestFrameAsync()
        {
            var frame = await Task.Run(() => _reader.ReadVideoFrame());
            return frame;
        }

        public async Task CloseFeed()
        {
            IsReady = false;
            await Task.Run(() => _reader.Close());
        }

        public Bitmap GetLatestFrame()
        {
            var count = _reader.FrameCount;
            var frame = _reader.ReadVideoFrame();
            return frame;
        }
    }
}
