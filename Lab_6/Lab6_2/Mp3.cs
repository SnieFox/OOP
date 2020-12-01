using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Mp3 : IRecordable
    {
        public void Record()
        {
            Console.WriteLine(".mp3 file can be recorded");
        }

        public void Pause()
        {
            Console.WriteLine(".mp3 file can be paused");
        }

        public void Stop()
        {
            Console.WriteLine(".mp3 file can be stopped\n\n");
        }
    }
}
