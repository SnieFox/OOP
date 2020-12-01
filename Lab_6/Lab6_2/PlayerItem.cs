using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public class PlayerItem : IMedia
    {
        public string[] media;
        //public int MediaLenght
        //{
        //    get { return media.Length; }
        //}

        public string this[int index]
        {
            get { return Path.GetFileNameWithoutExtension(media[index]); }
        }
        public void InitMedia(string path)
        {
            media = Directory.GetFiles(path);

            var dir = new DirectoryInfo(path);

            int n = 1;
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine($"{n}. {Path.GetFileNameWithoutExtension(file.FullName)}");
                n++;
            }

            n = 1;
        }
    }
}
