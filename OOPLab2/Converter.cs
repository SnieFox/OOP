using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    class Converter
    {
        public Converter(double USD, double EUR, double RUB, double UAH)
        {
            _usd = USD;
            _eur = EUR;
            _rub = RUB;
            _uah = UAH;
        }
        public double _usd { get; set; }
        public double _eur { get; set; }
        public double _rub { get; set; }
        public double _uah { get; set; }

        const double UAHtoUSD = 1/27.95;
        const double UAHtoEUR = 1/32.8500;
        const double UAHtoRUB = 1/0.3753;

        public void ValueConverter()
        {
            Console.WriteLine("Из какой валюты переводить?\n1.UAH\n2.USD\n3.EUR\n4.RUB\n");
            int from = int.Parse(Console.ReadLine());

            Console.WriteLine("В какую валюту переводить?\n1.UAH\n2.USD\n3.EUR\n4.RUB\n");
            int to = int.Parse(Console.ReadLine());

            double temp_value; 
            double result_value;
            double input_value;

            string from_value_name;
            string to_value_name;

            switch (from)
            {
                case 1:
                    input_value = _uah;
                    from_value_name = "UAH";
                    temp_value = _uah;
                    break;
                case 2:
                    input_value = _usd;
                    from_value_name = "USD";
                    temp_value = _usd / UAHtoUSD;
                    break;
                case 3:
                    input_value = _eur;
                    from_value_name = "EUR";
                    temp_value = _eur / UAHtoEUR;
                    break;
                case 4:
                    input_value = _rub;
                    from_value_name = "RUB";
                    temp_value = _rub / UAHtoRUB;
                    break;
                default:
                    input_value = 0;
                    from_value_name = "###";
                    temp_value = 0;
                    break;
            }

            switch (to)
            {
                case 1:
                    to_value_name = "UAH";
                    result_value = temp_value;
                    break;
                case 2:
                    to_value_name = "USD";
                    result_value = temp_value * UAHtoUSD;
                    break;
                case 3:
                    to_value_name = "EUR";
                    result_value = temp_value * UAHtoEUR;
                    break;
                case 4:
                    to_value_name = "RUB";
                    result_value = temp_value * UAHtoRUB;
                    break;
                default:
                    to_value_name = "###";
                    result_value = 0;
                    break;
            }

            Console.WriteLine($"Результат {input_value} {from_value_name} = {result_value} {to_value_name}");

        }

    }
}
