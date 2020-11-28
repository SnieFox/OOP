using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Counting
    {
        public Counting(MainWindow main)
        {
            this.main = main;

        }

        MainWindow main;
        public void Indicators(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9)
        {
            List<int> numList = new List<int>();
            numList.Add(num1);
            numList.Add(num2);
            numList.Add(num3);
            numList.Add(num4);
            numList.Add(num5);
            numList.Add(num6);
            numList.Add(num7);
            numList.Add(num8);
            numList.Add(num9);

            string average = Math.Round(numList.Average(),2).ToString();
            string max = numList.Max().ToString();
            string min = numList.Min().ToString();
            string summ = numList.Sum().ToString();
            string odd = "";
            foreach (var i in numList)
            {
                if (i % 2 != 0)
                {
                    odd += $"{i.ToString()} ";
                }
            }

        }

    }
}
