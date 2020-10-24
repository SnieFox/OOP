using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Напишите Exit для выхода. Введите любую клавишу, чтобы начать заново.");
            string a = "";
            bool b = true;
            while(b)
            {
                if (a == "exit")
                {
                    b = false;
                }
                else Show.ShowMessage();
                a = Console.ReadLine();
            }

        }
    }
}
