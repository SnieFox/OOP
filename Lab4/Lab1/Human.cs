using System.Diagnostics;
using System.Security;

namespace Lab4
{
    public class Human
    {
        public Human() { }
        public Human(string Name, string LastName, int Age, string Gender)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void ShowMessage()
        {
            Debug.WriteLine(
                $"Name: {Name}\n" +
                $"Last Name: {LastName}\n" +
                $"Gender: {Gender}\n" +
                $"Age: {Age}");
        }
    }
}


