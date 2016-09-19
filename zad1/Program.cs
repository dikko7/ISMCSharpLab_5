using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x и y:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = (x + (2 + y) / (x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
            double q = 2.8 * Math.Sin(x) + Math.Abs(y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("q = " + q);
        }
    }
}
