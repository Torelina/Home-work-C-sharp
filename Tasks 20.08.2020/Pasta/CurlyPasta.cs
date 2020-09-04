using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
    public class CurlyPasta : Pasta
    {
        public enum TypeCurlyPasta { }
        public static void Main()
        {
            string TestPasta = Console.ReadLine();
            switch (TestPasta)
            {
                case 1:
                    Console.WriteLine("Это - ракушки, спиральки, косички,лилии");
                    break;
                case 2:
                    Console.WriteLine("Это - вездочки, буквы алфавита, шестереноки");
                    break;
                default:
                    Console.WriteLine("Данное изделие не являеться фигурными макаронами");
                    break;
            }
        }
    }
}
