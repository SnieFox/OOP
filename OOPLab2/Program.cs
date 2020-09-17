using OOPLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\n");
            Address address = new Address(02099, "Ukraine", "Kyiv", "Rosiyskaya", 15, 41);
            address.ShowAddress();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 2\n");
            Console.Write("Length: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, length);
            Console.WriteLine($"Area: {rectangle.Area}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 3\n");
            Console.Write($"Title: ");
            Title title = new Title(Console.ReadLine());
            Console.Write($"Author: ");
            Author author = new Author(Console.ReadLine());
            Console.Write($"Content: ");
            Content content = new Content(Console.ReadLine());
            Book book = new Book(title, author, content);
            book.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 4\n");
            Figure figure = new Figure(
                            new Point(5, 5, "A"),
                            new Point(5, 1, "B"),
                            new Point(31, 24, "C"),
                            new Point(54, 77, "D"),
                            new Point(-49, 74, "E"));
            figure.Perimeter();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 5\n");
            User user = new User("Memes", "Daniil", "Ohorodnik", 18, DateTime.Now);
            user.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 6\n");
            Converter converter = new Converter(14, 144, 765, 117);
            converter.ValueConverter();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 7\n");
            Employee employee = new Employee("Daniil", "Ohorodnik");
            employee.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Task 8\n");
            Invoice invoice = new Invoice(16847, "Ohorodnik", "Galushki");
            invoice.Price();
            Console.ReadKey();
        }
    }
}
