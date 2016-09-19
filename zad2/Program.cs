using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMCSharpLab5_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 1st a:");
            int a = int.Parse(Console.ReadLine());
            a *= a;
            int b;
            b = a;
            b *= b;
            Console.WriteLine(b);
            Console.WriteLine("Write 2nd a:");
            a = int.Parse(Console.ReadLine());
            a *= a;
            b = a;
            b *= b;
            
        }
    }
}
