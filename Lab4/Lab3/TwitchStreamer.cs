using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TwitchStreamer : Streamer
    {
        public TwitchStreamer(string Name, string Channel, int StreamingAge, int NumOfSubscribers, int Followers, string Squad)
            :base(Name,Channel,StreamingAge)
        {
            this.NumOfSubscribers = NumOfSubscribers;
            this.Followers = Followers;
            this.Squad = Squad;
        }

        public int Followers { get; set; }
        public string Squad { get; set; }
        public int NumOfSubscribers { get; set; }

        public void ShowMessage()
        {
            Debug.WriteLine(
                "Class TwitchStreamer: \n" +
                $"Name: {Name}\n" +
                $"Channel: {Channel}\n" +
                $"Streams for {StreamingAge} month\n" +
                $"Number of Subscribers: {NumOfSubscribers}\n" +
                $"Number of Followers: {Followers}\n" +
                $"Squad: {Squad}\n");
        }
    }
}
