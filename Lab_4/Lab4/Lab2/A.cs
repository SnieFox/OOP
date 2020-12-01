using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class A
    {
        public A(B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A(B b1, B b2) : this(b1, b2, null) { }

        B b1;
        B b2;
        B b3;

        public void Point()
        {
            if (b3 == null)
            {
                Debug.WriteLine($"Name: {b1.Name}; ({b1.X},{b1.Y})\n" +
                                $"Name: {b2.Name}; ({b2.X},{b2.Y})");
            }
            else
            {
                Debug.WriteLine($"Name: {b1.Name}; ({b1.X},{b1.Y})\n" +
                                $"Name: {b2.Name}; ({b2.X},{b2.Y})\n" +
                                $"Name: {b3.Name}; ({b3.X},{b3.Y})");
            }
        }
    }
}

