using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab2
{
    class Invoice
    {
        public int account { get; private set; }
        public string customer { get; private set; }
        public string provider { get; private set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        string[] goods = { "Процессор", "Видеокарта", "SSD", "Материнская плата", "Память", "HDD", "Блок питания", "Корпус", "Охлаждение", "Кулер" };
        static int[] quality = { 15, 20, 0, 2, 7, 10, 0, 30, 4, 2 };

        const double tax = 20; // НДС - 20%

        public void Price()
        {
            double[] price = { 4000, 12000, 500, 3000, 2000, 500, 1000, 894.99, 400.99, 135.99 };

            Console.WriteLine($"Выберите номер товара, который хотите заказать:");
            for (int i = 0; i < goods.Length; i++)
                Console.WriteLine($"{i + 1}. {goods[i]} по цене: {price[i]} UAH\t*Осталось в наличии {quality[i]} штук*");

            int n = Convert.ToInt32(Console.ReadLine());

            if ((quality[n - 1] - 1) < 0)
            {
                Console.WriteLine($"\nТовара {goods[n - 1]} нет в наличии");
            }
            else
            {
                quality[n - 1]--;
                Console.WriteLine(
                    $"\nАккаунт: {account}\n" +
                    $"Покупатель: {customer}\n" +
                    $"Поставщик: {provider}\n" +
                    $"Товар: {goods[n - 1]}\n" +
                    $"Цена: {price[n - 1]}\n" +
                    $"Цена с НДС: {(price[n - 1] * tax / 100) + price[n - 1]}");
            }
        }
    }
}
