using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость 1кг Петровских конфет: ");
            double K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг Воронежских конфет: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг  конфет Чародейка: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг конфет Факел: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг конфет Ласточка: ");
            double L = Convert.ToDouble(Console.ReadLine());
            double U = ((200 * K) / 1000) + ((300 * P) / 1000) + ((250 * R) / 1000) + ((150 * B) / 1000) + ((200 * L) / 1000);
            Console.WriteLine("Стоимость упаковки: {0} руб.", U);
            Console.ReadKey();
        }
    }
}
