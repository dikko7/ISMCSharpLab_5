using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            int c = (a / 10) % 10;
            int d = a / 100;
            Console.Write("" + d);
            Console.Write("" + b);
            Console.WriteLine("" + c);
            Console.ReadKey();
        }
    }
}
