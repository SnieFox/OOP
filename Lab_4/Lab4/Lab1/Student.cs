using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lab4._1
{
    public class Student : Human
    {
        public Student() : base() { }
        public Student(string Name, string LastName, int Age, string Gender, string University, string Group, int Mark)
            : base(Name, LastName, Age, Gender)
        {
            this.University = University;
            this.Group = Group;
            this.Mark = Mark;
        }
        public string University { get; set; }
        public string Group { get; set; }
        public int Mark { get; set; }

        public void ShowMessage()
        {
            Debug.WriteLine(
                $"Name: {Name}\n" +
                 $"Gender: {Gender}\n" +
                $"Age: {Age}\n" +
               $"Last Name: {LastName}\n" +
                $"University: {University}\n" +
                $"Group: {Group}\n" +
                $"Mark: {Mark}");
        }
    }
}

