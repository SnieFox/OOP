using System;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDateArray dateArray = new MyDateArray();

                Console.WriteLine($"Current date: {dateArray[0]}");

                Console.WriteLine($"Current date +15 days: {dateArray[15]}");
                Console.WriteLine($"Current date +7 days: {dateArray[7]}");

                Console.WriteLine($"Current date -17 days: {dateArray[-17]}");
                Console.WriteLine($"Current date -159 days: {dateArray[-159]}");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так, проверьте правильность введённых данных");
            }


        }
    }
}