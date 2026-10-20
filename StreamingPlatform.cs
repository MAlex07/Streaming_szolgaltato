using System;
using System.Collections.Generic;
using System.Text;

namespace Streaming_szolgaltato
{
    internal class StreamingPlatform
    {
        private List<IContent> contents;

        public StreamingPlatform()
        {
            contents = new List<IContent>();
        }

        public void AddContent(IContent content)
        {
            contents.Add(content);
        }

        public void LoadFile(string filename)
        {
            string[] sorok = File.ReadAllLines(filename);

            string seriesTitle = "";
            List<VIdeo> episodes = new List<VIdeo>();

            foreach(string sor in sorok)
            {
                string[] data = sor.Split(';');

                if (data[0] == "MOVIE")
                {
                    if (seriesTitle != "")
                    {
                        AddContent(new Series(seriesTitle, episodes));
                        seriesTitle = "";
                        episodes = new List<VIdeo>();
                    }

                    VIdeo video = new VIdeo(data[1], int.Parse(data[2]));
                    Movie movie = new Movie(video);

                    AddContent(movie);
                }else if(data[0] == "SERIES")
                {
                    if (seriesTitle != "")
                    {
                        AddContent(new Series(seriesTitle, episodes));
                    }

                    seriesTitle = data[1];
                    episodes = new List<VIdeo>();
                }
                else if (data[0] == "EPISODE")
                {
                    VIdeo video = new VIdeo(data[1], int.Parse(data[2]));
                    episodes.Add(video);
                }
            }

            if (seriesTitle != "")
            {
                AddContent(new Series(seriesTitle, episodes));
            }

        }

        public IContent GetLongest()
        {
            if (contents.Count == 0)
            {
                return null;
            }

            IContent longest = contents[0];

            foreach (IContent content in contents)
            {
                if (content.GetLength() > longest.GetLength())
                {
                    longest = content;
                }
            }

            return longest;
        }
    }
}
