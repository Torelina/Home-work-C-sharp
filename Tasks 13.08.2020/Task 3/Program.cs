using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое ненулевое число: ");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе ненулевое число: ");
            double two = Convert.ToDouble(Console.ReadLine());
            double sum = one + two;
            double diff = one - two;
            double mult = one * two;
            double div = one / two;
            Console.WriteLine("Сумма: {0}, Разность: {1}, Произведение: {2}, Частное: {3}", sum, diff, mult, div);
            Console.ReadKey();
        }
    }
}
