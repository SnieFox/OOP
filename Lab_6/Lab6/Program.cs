using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите тип файла, который хотите открыть:");
                Console.WriteLine("1. Excel");
                Console.WriteLine("2. Word");
                Console.WriteLine("3. Notepad");
                bool choise = int.TryParse(Console.ReadLine(), out int result);
                if (choise)
                {
                    switch (result)
                    {
                        case 1:
                            AbstractHandler xls = new XLSFile();
                            xls.Create();
                            xls.Open();
                            xls.Change();
                            break;
                        case 2:
                            AbstractHandler doc = new DOCFile();
                            doc.Create();
                            doc.Open();
                            doc.Change();
                            break;
                        case 3:
                            AbstractHandler txt = new TXTFile();
                            txt.Create();
                            txt.Open();
                            txt.Change();
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод.\n");
                            break;
                    }
                }
            }
        }
    }
}
