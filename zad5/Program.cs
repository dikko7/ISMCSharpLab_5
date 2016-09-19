using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число n(10<=n<=999), чтобы число десятков не было равно нулю: ");
            int n = int.Parse(Console.ReadLine());

            int a = n / 100;
            int b = (n / 10) % 10;

            int c = n % 10;
            if ((b!=0) && (n >= 10) && (n <= 999))
            {
                Console.Write("" + b);
                Console.Write("" + a);
                Console.WriteLine("" + c);
                Console.ReadKey();
            }
            
            else
                Console.WriteLine("Ошибка: n не отвечает требованиям или число десятков равно нулю !!!");
        }
    }
}
