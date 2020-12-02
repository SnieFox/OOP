using System;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(42, 55);
            array[-5] = 32.42d;
            Console.WriteLine(array[0] + ", " + array[1] + ", " + array[-5]);
        }
    }
}
