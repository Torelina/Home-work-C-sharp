using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
    abstract class Pasta
    {
        
        public void Composition(string Dough)
        {
            Dough = Console.ReadLine();
            if (Dough == "мука вода")
            {
                Console.WriteLine("Это макароны");
                
            }
            else
            {
                Console.WriteLine("Ошибка, данный продукт не относится к макоронам");
            }
            Console.ReadKey();
        }
        
    }
}
