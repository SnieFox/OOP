using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Employee
    {
        public string name { get; set; }
        public string lastName { get; set; }

        public Employee(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public void Show()
        {
            int minSalary = 8000;
            int positionRatio = 25;
            int seniorityRatio = 10;
            double tax = 19.5;
            string[] positionName = {"Продавец","Старший продавец","Менеджер","Директор"};

            Console.WriteLine("Выберите должность:\n"
                             + "1. Продавец\n"
                             + "2. Старший продавец\n"
                             + "3. Менеджер\n"
                             + "4. Директор\n");
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine("Напишите ваш стаж: ");
            int seniority = int.Parse(Console.ReadLine());

            double salary = minSalary;
            for(int i=0;i<position;i++)
            {
                salary += salary * positionRatio / 100;
            }

            int temp = 0;
            double tempSalary = salary;
            for(int i=0;i< seniority&&i>2;i+=3)
            {
                tempSalary += tempSalary * seniorityRatio / 100;
                temp++;
            }
            if(temp>0) tempSalary -= minSalary;
            else tempSalary -= tempSalary;
            salary += tempSalary;

            Console.WriteLine(
                $"\nФамилия: {lastName}\n" +
                $"Имя: {name}\n" +
                $"Должность: {positionName[position - 1]}\n" +
                $"Оклад: {salary}\n" +
                $"Налоговый сбор: {salary * tax / 100}");
        }
    }
}
