using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите свой рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double c = 100;
            double weight = height - c;
            Console.WriteLine("Ваш идеальный вес: {0}", weight );
            Console.ReadKey(); 



        }
    }
}
