using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Content
    {
        public string ContentName { get; set; }
        public Content(string ContentName)
        {
            this.ContentName = ContentName;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ContentName);
            Console.ResetColor();
        }
    }
}
