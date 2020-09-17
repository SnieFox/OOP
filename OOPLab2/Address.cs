using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPLab2
{
    class Address
    {

        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Index: {index}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Street: {street}");
            Console.WriteLine($"House: {house}");
            Console.WriteLine($"Apartment: {apartment}");
        }

    }
}
