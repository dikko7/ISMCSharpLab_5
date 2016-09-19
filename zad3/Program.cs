using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            Console.WriteLine(b);
            Console.WriteLine("Введите число снова:");
            int c = int.Parse(Console.ReadLine());
            int d = (c / 10) % 10;
            Console.WriteLine(d);
            Console.WriteLine("Ещё:");
            int e = int.Parse(Console.ReadLine());
            int f = e % 10;
            int g = (e / 10) % 10;
            int h = e / 100;
            int i = f + g + h;
            Console.WriteLine(i);
            Console.WriteLine("Ещё число:");
            int j = int.Parse(Console.ReadLine());
            int k = j % 10;
            int l = (j / 10) % 10;
            int m = j / 100;
            int n = k * l * m;
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
