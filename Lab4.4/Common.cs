using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Common
    {
        public static void Show()
        {
            Console.WriteLine("Добро пожаловать в калькулятор Площади фигур.\n" +
                "Бесплатный период включает в себя нахождение параметров для Квадрата и Прямоугольника\n");
            Console.Write("Введите желаемую фигуру(Квадрат/Прямоугольник): ");
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "квадрат":
                    Calculators.Square();
                    break;
                case "прямоугольник":
                    Calculators.Rectangle();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }
    }
}
