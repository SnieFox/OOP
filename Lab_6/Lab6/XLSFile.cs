using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class XLSFile : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine(".xsl-File created");
        }

        public override void Open()
        {
            Console.WriteLine(".xls-File opened");
        }

        public override void Change()
        {
            Console.WriteLine(".xls-File changed\n");
        }
    }
}
