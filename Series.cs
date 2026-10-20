using System;
using System.Collections.Generic;
using System.Text;

namespace Streaming_szolgaltato
{
    internal class Series : IContent
    {
        private string title;
        private List<VIdeo> videos;

        public Series(string title, VIdeo video)
        {
            this.title = title;
            videos = new List<VIdeo>();
            videos.Add(video);


        }

        public Series(string title, List<VIdeo> videos)
        {
            this.title = title;
            this.videos = videos;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetLength()
        {
            int sum = 0;

            foreach (VIdeo video in videos)
            {
                sum += video.GetLength();
            }

            return sum;
        }
    }
}
