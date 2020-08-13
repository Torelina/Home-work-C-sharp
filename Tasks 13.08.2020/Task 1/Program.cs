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
            int height = Convert.ToInt32(Console.ReadLine());
            int c = 100;
            int weight = height - c;
            Console.WriteLine("Ваш идеальный вес: {0}", weight );
            Console.ReadKey(); 



        }
    }
}
