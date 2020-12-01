using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Streamer
    {
        public Streamer(string Name, string Channel, int StreamingAge)
        {
            this.Name = Name;
            this.Channel = Channel;
            this.StreamingAge = StreamingAge;
        }

        public string Name { get; set; }
        public string Channel {get;set;}
        public int StreamingAge { get; set; }

        public void ShowMessage()
        {
            Debug.WriteLine(
                "Class Streamer: \n" +
                $"Name: {Name}\n" +
                $"Channel: {Channel}\n" +
                $"Streams for {StreamingAge} month\n");
        }
    }
}
