using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Mkv : IPlayable
    {
        public void Play()
        {
            Console.WriteLine(".mkv file can be played");
        }

        public void Pause()
        {
            Console.WriteLine(".mkv file can be paused");
        }

        public void Stop()
        {
            Console.WriteLine(".mkv file can be stopped\n\n");
        }
    }
}
