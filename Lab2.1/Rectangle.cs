using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double perim = (side1 + side2) * 2;
            return perim;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
            private set
            {
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
            private set
            {
            }
        }

    }
}
