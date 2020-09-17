using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Author
    {
        public string AuthorName { get; set; }
        public Author(string AuthorName)
        {
            this.AuthorName = AuthorName;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(AuthorName);
            Console.ResetColor();
        }
    }
}
