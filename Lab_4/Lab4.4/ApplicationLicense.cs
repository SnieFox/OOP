using Lab4._4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ApplicationLicense
    {

        public static void AllowTrial()
        {
            Console.WriteLine("Trial");
            Trial.Show();
        }

        public static void AllowCommon()
        {
            Console.WriteLine("Common");
            Common.Show();
        }

        public static void AllowPro()
        {
            Console.WriteLine("Pro");
            Pro.Show();
        }
    }
}
