/*
Записать логические выражения, которые имеют значение «Истина»
только при выполнении указанных условий:
а) x < 2 и у < 3;
б) неверно, что x < 2;
в) x < 1 или y < 2;
г) неверно, что (x < 0 и x < 5);
д) x < 0 и у > 5;
е) 10 < x < 20;
ж) x > 3 или x < 1;
з) 0 < y < 4 и x < 5;
и) х > 3  и x < 10
*/

using System;

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а)");
            Console.Write("Введите число x: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y1 = double.Parse(Console.ReadLine());
            bool z1 = x1 < 2 && y1 < 3;
            Console.WriteLine($"{x1} < 2 и {y1} < 3 = {z1}");

            Console.Write("б)");
            Console.Write("Введите число x: ");
            double x2 = double.Parse(Console.ReadLine());
            bool z2 = !(x2 < 2);
            Console.WriteLine($"неверно, что {x2} < 2 = {z2}");

            Console.Write("в)");
            Console.Write("Введите число x: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y3 = double.Parse(Console.ReadLine());
            bool z3 = (x3 < 1) || (y3 < 2);
            Console.WriteLine($"{x3} < 1 или {y3} < 2 = {z3}");

            Console.Write("г)");
            Console.Write("Введите число x: ");
            double x4 = double.Parse(Console.ReadLine()); ;
            bool z4 = !((x4 < 0) && (x4 < 5));
            Console.WriteLine($"неверно, что ({x4} < 0 и {x4} < 5) = {z4}");

            Console.Write("д)");
            Console.Write("Введите число x: ");
            double x5 = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y5 = double.Parse(Console.ReadLine());
            bool z5 = (x5 < 0) && (y5 > 5);
            Console.WriteLine($"{x5} < 0 и {y5} > 5 = {z5}");

            Console.Write("е)");
            Console.Write("Введите число x: ");
            double x6 = double.Parse(Console.ReadLine());
            bool z6 = (10 < x6) && (x6 < 20);
            Console.WriteLine($"10 < {x6} < 20 = {z6}");

            Console.Write("ж)");
            Console.Write("Введите число x: ");
            double x7 = double.Parse(Console.ReadLine());
            bool z7 = (x7 > 3) || (x7 < 1);
            Console.WriteLine($"{x7} > 3 или {x7} < 1 = {z7}");

            Console.Write("з)");
            Console.Write("Введите число x: ");
            double x8 = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y8 = double.Parse(Console.ReadLine());
            bool z8 = ((0 < y8) && (y8 < 4)) && (x8 < 5);
            Console.WriteLine($"0 < {y8} < 4 и {x8} < 5 = {z8}");

            Console.Write("и)");
            Console.Write("Введите число x: ");
            double x9 = double.Parse(Console.ReadLine());
            bool z9 = (x9 > 3) && (x9 < 10);
            Console.WriteLine($"{x9} > 3  и {x9} < 10 = {z9}");
        }
    }
}
