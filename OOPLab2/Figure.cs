using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Figure
    {
        Point pointA;
        Point pointB;
        Point pointC;
        Point pointD;
        Point pointE;
        public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
            this.pointE = pointE;
        }
        public Figure(Point pointA, Point pointB, Point pointC) : this(pointA, pointB, pointC, null, null) { }
        public Figure(Point pointA, Point pointB, Point pointC, Point pointD) : this(pointA, pointB, pointC, pointD, null) { }

        private double LengthSide(Point pointA, Point pointB)
        {
            double result = Math.Sqrt(Math.Pow((pointB.X1 - pointA.X1), 2) + Math.Pow((pointB.X2 - pointA.X2), 2));
            return result;
        }

        public void Perimeter()
        {
            double result;

            if (pointD == null && pointE == null)
            {
                result = LengthSide(pointA, pointB) + LengthSide(pointB, pointC) + LengthSide(pointC, pointA);
                Console.WriteLine($"Perimeter {pointA.Name + pointB.Name + pointC.Name} : {result}");
            }
            else if (pointE == null)
            {
                result = LengthSide(pointA, pointB) + LengthSide(pointB, pointC) + LengthSide(pointC, pointD) + LengthSide(pointD, pointA);
                Console.WriteLine($"Perimeter {pointA.Name + pointB.Name + pointC.Name + pointD.Name} : {result}");
            }
            else
            {
                result = LengthSide(pointA, pointB) + LengthSide(pointB, pointC) + LengthSide(pointC, pointD) + LengthSide(pointD, pointE) + LengthSide(pointE, pointA);
                Console.WriteLine($"Perimeter {pointA.Name + pointB.Name + pointC.Name + pointD.Name + pointE.Name} : {result}");
            }
        }

    }
}
