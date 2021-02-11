using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{

    class Program
    {
        delegate double del();
        delegate double Average(del[] x);
        static void Main(string[] args)
        {
            del[] deleg = new del[10];
            Random rand = new Random();
            for (int i = 0; i < deleg.Length; i++)
            {
                deleg[i] = () => { return rand.Next(0, 10); };
            }
            Average avgdel = delegate (del[] deleg1)
            {
                double sum = 0;
                double num;
                for (int i = 0; i < deleg1.Length; i++)
                {
                    num = deleg1[i]();
                    sum += num;
                    Console.WriteLine($"{i + 1} число = {num}");
                }
                return sum / deleg1.Length;
            };
            Console.WriteLine($"Среднее арифметическое значений массива: {avgdel(deleg)}");
            Console.ReadLine();
        }
    }
}
