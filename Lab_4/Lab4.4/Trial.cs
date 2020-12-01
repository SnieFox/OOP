using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Trial
    {
        public static void Show()
        {
            Console.WriteLine("Добро пожаловать в калькулятор Площади фигур.\n" +
                "Пробный период включает в себя нахождение параметров для Квадрата, Прямоугольника , Треугольника и Ромба\n");
            Console.Write("Введите желаемую фигуру(Квадрат/Прямоугольник/Треугольник/Ромб): ");
            string figure = Console.ReadLine().ToLower();
            switch(figure)
            {
                case "квадрат":
                    Calculators.Square();
                    break;
                case "прямоугольник":
                    Calculators.Rectangle();
                    break;
                case "треугольник":
                    Calculators.Triangle();
                    break;
                case "ромб":
                    Calculators.Rhombus();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }

       



    }
}
