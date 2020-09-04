using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
     class StringPasta: Pasta
    {
        public static void Main()
        {
            Console.WriteLine("Введите размер поперечного сечения (в мм)");
            int TestPastaString = Convert.ToInt32(Console.ReadLine());
            switch (TestPastaString)
            {
                case 1:
                    Console.WriteLine("Это - паутинка");
                    break;
                case 2:
                    Console.WriteLine("Это - тонкая");
                    break;
                case 3:
                    Console.WriteLine("Это - обыкновенная");
                    break;
                case 4:
                    Console.WriteLine("Это - любительская");
                    break;
                default:
                    Console.WriteLine("Данное изделие не является вермишелью");
                    break;
            }
        }
    }
}
