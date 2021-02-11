using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public delegate double Numbers(int num1, int num2, int num3);
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter num3: ");
            int number3 = int.Parse(Console.ReadLine());

            Numbers nums = delegate(int num1, int num2, int num3)
            {
                double avr = (num1 + num2 + num3) / 3d;
                return avr;
            };
            Console.WriteLine($"Average of {number1},{number2},{number3} = {Convert.ToString(nums(number1, number2, number3))}");
            Console.ReadLine();
        }
    }
}
