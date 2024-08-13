using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.YouTube
{
    internal class Channel
    {
        public string ChanelName { get; set; }
        public List<Videos> videos { get; set; }

        public void AddVideo (Videos video)
        {
            videos.Add(video);
            UploadVideo?.Invoke(video,this);
        }

        public event Action<Videos,Channel>? UploadVideo;

        public override string ToString()
        {
            return $"Chanel Name: {ChanelName}";
        }

        public Channel()
        {
            videos = new List<Videos>();
        }
    }
}
