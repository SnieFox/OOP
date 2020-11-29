using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    public class MyMatrix
    {
        public string CreateMatrices(int n, int m)
        {
            Random random = new Random();
            string[,] baseMatrixArray = new string[n, m];
            string matrix = "";
            string baseMatrix = "";
            string derMatrix1 = "";
            string derMatrix2 = "";
            string derMatrix3 = "";
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    int radElem = random.Next(0, 10);
                    baseMatrix +=$"{Convert.ToString(radElem)}  ";
                    baseMatrixArray[i, j] = Convert.ToString(radElem);
                }

                baseMatrix += "\n";
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    if (j > m-1)
                    {
                        //if (j == m) derMatrix1 = derMatrix1.Remove(derMatrix1.Length - 1);
                        derMatrix1 += $"{Convert.ToString(random.Next(0, 10))}  ";
                    }
                    else
                    {
                        derMatrix1 += $"{baseMatrixArray[i, j]}  ";

                    }
                }

                derMatrix1 += "\n";
            }

            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (i > n - 1)
                    {
                        //if (i == n) derMatrix2 = derMatrix2.Remove(derMatrix2.Length - 1);
                        derMatrix2 += $"{Convert.ToString(random.Next(0, 10))}  ";
                    }
                    else
                    {
                        derMatrix2 += $"{baseMatrixArray[i, j]}  ";
                    }
                }

                derMatrix2 += "\n";
            }

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < 15; j++)
                {
                    if (j > m - 1)
                    {
                        //if (j == m) derMatrix3 = derMatrix3.Remove(derMatrix3.Length - 1);
                        derMatrix3 += $"{Convert.ToString(random.Next(0, 10))}  ";
                    }
                    else
                    {
                        derMatrix3 += $"{baseMatrixArray[i, j]}  ";
                    }
                }

                derMatrix3 += "\n";
            }

            matrix += $"{baseMatrix},{derMatrix1},{derMatrix2},{derMatrix3}";
            return matrix;
        }
       
    }
    
}
