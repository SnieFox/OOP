using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Wav : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine(".wav file can be played");
        }
        public void Record()
        {
            Console.WriteLine(".wav file can be recorded");
        }

        public void Pause()
        {
            Console.WriteLine(".wav file can be paused");
        }

        public void Stop()
        {
            Console.WriteLine(".wav file can be stopped\n\n");
        }
    }
}
