using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.000000;
            int x = 2;
            int i;
            double ii;
            for (i = 3; i <= 12; i++)
            {
                ii = i;
                if (i % 2 == 1) { sum -= ((ii - 1) / ii) * Math.Pow(x, ii - 2); } else sum += ((ii - 1) / ii) * Math.Pow(x, ii - 2);
            }
            sum += 1.0;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
