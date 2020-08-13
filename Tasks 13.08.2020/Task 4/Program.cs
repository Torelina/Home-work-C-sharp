using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние(км) от школы до стадиона: ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите среднюю скорость(км/ч) движения: ");
            double V = Convert.ToDouble(Console.ReadLine());
            double T = (S / V) * 60;
            Console.WriteLine("Время в минутах, которое затратит школьник на дорогу от школы до стадиона: {0}", T);
            Console.ReadKey();
        }
    }
}
