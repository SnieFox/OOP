using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class User
    {
        public User(string login, string name, string lastName, int age, DateTime date)
        {
            this.login = login;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.date = date;
        }
        public string login { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime date { get; private set; }
        public void Show()
        {
            Console.WriteLine($"Login: {login}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Date: {date}");        
        }
    }
}
