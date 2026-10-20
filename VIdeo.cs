using System;
using System.Collections.Generic;
using System.Text;

namespace Streaming_szolgaltato
{
    internal class VIdeo
    {
        private string title;
        private int length;

        public VIdeo(string title, int length)
        {
            this.title = title;
            this.length = length;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetLength()
        {
            return length;
        }
    }
}
