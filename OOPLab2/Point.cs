using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Point
    {
        public int X1 { get; }
        public int X2 { get; }
        public string Name { get; }
        public Point(int X1, int X2, string Name)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Name = Name;
        }

        
    }
}
