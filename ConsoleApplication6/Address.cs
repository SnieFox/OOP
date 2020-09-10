using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Address MyAddress = new Address(02099, "Ukraine", "Kyiv", "Boryspilska", 9, 542);
            MyAddress.AddresOutput();
            Console.ReadLine();
        }

        

    }
    class Address
    {
        public Address(int index, string country, string sity, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.sity = sity;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public int index { get; set; }
        public string country { get; set; }
        public string sity { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }

        public void AddresOutput()
        {
            Console.WriteLine($"Index: {index}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Sity: {sity}");
            Console.WriteLine($"Street: {street}");
            Console.WriteLine($"House: {house}");
            Console.WriteLine($"Apartment: {apartment}");
        }
    }
}
