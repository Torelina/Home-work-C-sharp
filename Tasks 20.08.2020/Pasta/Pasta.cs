using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
    public class Pasta
    {
        
        public void Composition(string Dough)
        {
            Console.WriteLine("По составу это");
            if (Dough == "мука+вода")
            {
                Console.WriteLine("Это макароны");
                
            }
            else
            {
                Console.WriteLine("Ошибка, данный продукт не относится к макаронам");
            }
        
            
        }
        
    }
}
