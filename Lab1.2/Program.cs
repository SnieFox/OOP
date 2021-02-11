using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Program
    {
        public delegate double Calculator(double x, double y);
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите оперцию(+,-,*,/): ");
                string operation = Console.ReadLine();

                Console.WriteLine("Введите первое число: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                Calculator calc;

                switch (operation)
                {
                    case "+":
                        calc = (num1, num2) => num1 + num2;
                        Console.WriteLine($"{number1} + {number2} = {calc(number1,number2)}");
                        break;
                    case "-":
                        calc = (num1, num2) => num1 - num2;
                        Console.WriteLine($"{number1} - {number2} = {calc(number1, number2)}");
                        break;
                    case "*":
                        calc = (num1, num2) => num1 * num2;
                        Console.WriteLine($"{number1} * {number2} = {calc(number1, number2)}");
                        break;
                    case "/":
                        calc = (num1, num2) =>
                        {
                            if (num2 != 0)
                            {
                                return num1 / num2;
                            }
                            else
                            {
                                throw new Exception("На ноль делить нельзя!");
                            }
                        };
                        Console.WriteLine($"{number1} / {number2} = {calc(number1, number2)}");
                        break;
                    default:
                        Console.WriteLine("Введите одну из предложенных операций.");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops!.......................{0}",ex.Message);
                
            }

            Console.ReadKey();
        }
    }
}
