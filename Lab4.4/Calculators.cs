using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Calculators
    {
        public static void Square()
        {
            double a = 0;
            double s = 0;
            Console.WriteLine("1. Зная длину стороны\n" +
                "2. Зная диаметр");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    s = a * a;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите  диаметр: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    s = a * a / 2;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }
        public static void Rectangle()
        {
            double a = 0;
            double b = 0;
            double s = 0;
            Console.WriteLine("Введите первую сторону: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую: ");
            b = Convert.ToDouble(Console.ReadLine());

            s = a * b;
            Console.WriteLine($"Площадь: {s}");
        }
        public static void Triangle()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double s = 0;
            Console.WriteLine("1. Формула Герона\n" +
                "2. Зная сторону и высоту\n" +
                "3. Зная две стороны и угол между ними");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    double semiP = (a + b + c) / 2;
                    s = Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите  сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    s = (a + b) / 2;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 3:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите угол между ними: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    s = a * b * Math.Sin(c)/2;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }

        }

        public static void Parallelogram()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double s = 0;
            Console.WriteLine("1. Зная длину стороны и высоту\n" +
                "2. Зная две стороны и угол между ними\n" +
                "3. Зная две диагонали и угол между ними");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    s = a * b;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите угол между ними: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    s = a * b * Math.Sin(c);
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 3:
                    Console.WriteLine("Введите первую диагональ: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую диагональ: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите угол между ними: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    s = a * b * Math.Sin(c) / 2;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }

        public static void Rhombus()
        {
            double a = 0;
            double b = 0;
            double s = 0;
            Console.WriteLine("1. Зная длину стороны и высоту\n" +
                "2. Зная сторону и угол между ними\n" +
                "3. Зная диагонали");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    s = a * b;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите угол между ними: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    s = a * a * Math.Sin(b);
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 3:
                    Console.WriteLine("Введите диагональ: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    s = a * a / 2;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }

        public static void Trapezoid()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double s = 0;
            Console.WriteLine("1. Формула Герона для трапеции\n" +
                "2. Зная длину основ и высоту");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите первую сторону: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите четвертую сторону: ");
                    d = Convert.ToDouble(Console.ReadLine());

                    double semiPrerim = (a + b + c + d) / 2;
                    s = (a + b) / Math.Abs(a - b) * Math.Sqrt((semiPrerim - a) * (semiPrerim - b) * (semiPrerim - c) * (semiPrerim - d));
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите первую основу: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую основу: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    s = (a + b) / 2 * c;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }

        public static void Circle()
        {
            double a = 0;
            double s = 0;
            Console.WriteLine("1. Зная радиус\n" +
                "2. Зная диаметр");
            double choise = Convert.ToDouble(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите радиус: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    s = 3.14 * a * a;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                case 2:
                    Console.WriteLine("Введите диаметр: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    s = 3.14 * a * a / 4;
                    Console.WriteLine($"Площадь: {s}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }

        public static void Ellipse()
        {
            double a = 0;
            double b = 0;
            double s = 0;
            Console.WriteLine("Введите длину малой полуоси: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину большой полуоси: ");
            b = Convert.ToDouble(Console.ReadLine());

            s = 3.14 * a * b;
            Console.WriteLine($"Площадь: {s}");
        }
    }
}
