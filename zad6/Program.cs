using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 4 == 0 || (y % 100 == 0 && y % 400 == 0))
                Console.WriteLine("Этот год высокосный");
            else
                Console.WriteLine("Этот год не высокосный");
            Console.ReadKey();
        }
    }
}
