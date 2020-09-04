using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasta TestPasta = new Pasta();
           
            TestPasta.Composition("мука+вода");
            Console.ReadKey();
        }
    }
}
