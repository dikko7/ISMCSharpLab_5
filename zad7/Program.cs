using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m(номер масти) и n(номер карты): ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 6:
                    Console.Write("Шестёрка ");
                    break;
                case 7:
                    Console.Write("Семёрка ");
                    break;
                case 8:
                    Console.Write("Восьмёрка ");
                    break;
                case 9:
                    Console.Write("Девятка ");
                    break;
                case 10:
                    Console.Write("Десятка ");
                    break;
                case 11:
                    Console.Write("Валет ");
                    break;
                case 12:
                    Console.Write("Дама ");
                    break;
                case 13:
                    Console.Write("Король ");
                    break;
                case 14:
                    Console.Write("Туз ");
                    break;
                default:
                    Console.WriteLine("Такой карты нет!!");
                    break;
             }           
            switch (m)
            {
                case 1:
                    Console.WriteLine("пик");
                    break;
                case 2:
                    Console.WriteLine("трефы");
                    break;
                case 3:
                    Console.WriteLine("бубен");
                    break;
                case 4:
                    Console.WriteLine("червы");
                    break;
                default:
                    Console.WriteLine("Такой масти нет!!");
                    break;

            }
        }
    }
}
