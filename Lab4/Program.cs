using Lab4;
using Lab4._1;
using System;
using System.Diagnostics;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-е Задание
            Debug.WriteLine(new string('-', 30));
            Debug.WriteLine("1-е Задание:");

            Human human = new Human("Lexa", "White", 19, "Male");
            Debug.WriteLine($"This is class {human.GetType().Name}");
            human.ShowMessage();

            Student student = new Student("Daniil", "Ohorodnik", 19, "Male", "KNUTE", "2-6", 90);
            Debug.WriteLine($"This is class {student.GetType().Name}");
            student.ShowMessage();

            Human human1 = (Human)student;
            Debug.WriteLine($"This is class {human1.GetType().Name}");
            human1.ShowMessage();

            Student employee1 = (Student)human1;
            Debug.WriteLine($"This is class {employee1.GetType().Name}");
            employee1.ShowMessage();
            Debug.WriteLine(new string('-', 30));
            #endregion

            #region 2-е Задание
            Debug.WriteLine("2-е Задание:");

            A a1 = new A(
                new B(21, -14, "F"), new B(14.1550, 14, "V"), new B(154, -489, "Q"));
            a1.Point();

            A a2 = new A(
                new B(14, 14.22, "G"), new B(47, 854, "L"));
            a2.Point();

            B_1 b_1 = new B_1(154, 44, "ASE");
            B_2 b_2 = new B_2(14, 4, "SE");
            B_3 b_3 = new B_3(4, 484, "AE");

            A a3 = new A(b_1, b_2, b_3);
            a3.Point();
            Debug.WriteLine(new string('-', 30));
            #endregion
        }
    }
}

