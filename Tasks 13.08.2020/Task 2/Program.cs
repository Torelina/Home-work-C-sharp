using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите розничную цену мужского костюма: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double tradePrice = R - ((R * 7) / 100);
            Console.WriteLine("Оптовая цена мужского костюма: {0}", tradePrice);
            Console.ReadKey();
        }
    }
}
