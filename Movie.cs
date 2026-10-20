using System;
using System.Collections.Generic;
using System.Text;

namespace Streaming_szolgaltato
{
    internal class Movie : IContent
    {
        private VIdeo video;

        public Movie(VIdeo video)
        {
            this.video = video;
        }

        public string GetTitle()
        {
            return video.GetTitle();
        }

        public int GetLength()
        {
            return video.GetLength();
        }
    }
}
