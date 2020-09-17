using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Title
    {
        public string TitleName { get; set; }
        public Title(string TitleName)
        {
            this.TitleName = TitleName;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(TitleName);
            Console.ResetColor();
        }
    }
}
