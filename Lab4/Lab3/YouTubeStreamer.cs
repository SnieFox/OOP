using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class YouTubeStreamer : Streamer
    {
        public YouTubeStreamer(string Name, string Channel, int StreamingAge, int NumOfSubscribers, int Sponsors)
            :base(Name, Channel,StreamingAge)
        {
            this.NumOfSubscribers = NumOfSubscribers;
            this.Sponsors = Sponsors;
        }
        public int NumOfSubscribers { get; set; }
        public int Sponsors { get; set; }

        public void ShowMessage()
        {
            Debug.WriteLine(
                "Class YouTubeStreamer: \n" +
                $"Name: {Name}\n" +
                $"Channel: {Channel}\n" +
                $"Streams for {StreamingAge} month\n" +
                $"Number of Subscribers: {NumOfSubscribers}\n" +
                $"Number of Sponsors: {Sponsors}\n");
        }
    }
}
