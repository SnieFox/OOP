using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class TXTFile : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine(".txt-File created");
        }

        public override void Open()
        {
            Console.WriteLine(".txt-File opened");
        }

        public override void Change()
        {
            Console.WriteLine(".txt-File changed\n");
        }
    }
}
