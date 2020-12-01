using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class DOCFile : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine(".doc-File created");
        }

        public override void Open()
        {
            Console.WriteLine(".doc-File opened");
        }

        public override void Change()
        {
            Console.WriteLine(".doc-File changed\n");
        }
    }
}
