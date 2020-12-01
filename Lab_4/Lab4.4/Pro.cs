using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Pro
    {
        public static void Show()
        {
            Console.WriteLine("Добро пожаловать в калькулятор Площади фигур.\n" +
                "Пробный период включает в себя нахождение параметров для Квадрата, Прямоугольника , Треугольника, Ромба, Параллелограмма, Трапеции, Круга и Элипса\n");
            Console.Write("Введите желаемую фигуру(Квадрат/Прямоугольник/Треугольник/Ромб/Параллелограмм/Трапеция/Круг/Элипс): ");
            string figure = Console.ReadLine().ToLower();
            switch (figure)
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
                case "параллелограмм":
                    Calculators.Parallelogram();
                    break;
                case "трапеция":
                    Calculators.Trapezoid();
                    break;
                case "круг":
                    Calculators.Circle();
                    break;
                case "элипс":
                    Calculators.Ellipse();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }
    }
}
