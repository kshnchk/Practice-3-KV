/*
Даны четыре различных вещественных числа. Не используя полный
условный оператор, определить:
а) наибольшее из них;
б) наименьшее из них.
*/

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а)");
            Console.Write("Введите число A: ");
            double A1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число D: ");
            double D1 = double.Parse(Console.ReadLine());
            if ((A1 > B1) && (A1 > C1) && (A1 > D1))
            {
                Console.WriteLine($"{A1} - наибольшее число");
            }
            else if ((B1 > A1) && (B1 > C1) && (B1 > D1))
            {
                Console.WriteLine($"{B1} - наибольшее число");
            }
            else if ((C1 > A1) && (C1 > B1) && (C1 > D1))
            {
                Console.WriteLine($"{C1} - наибольшее число");
            }
            else if ((D1 > A1) && (D1 > B1) && (D1 > C1))
            {
                Console.WriteLine($"{D1} - наибольшее число");
            }

            Console.Write("б)");
            Console.Write("Введите число A: ");
            double A2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число D: ");
            double D2 = double.Parse(Console.ReadLine());
            if ((A2 > B2) && (A2 > C2) && (A2 > D2))
            {
                Console.WriteLine($"{A2} - наименьшее число");
            }
            else if ((B2 > A2) && (B2 > C2) && (B2 > D2))
            {
                Console.WriteLine($"{B2} - наименьшее число");
            }
            else if ((C2 > A2) && (C2 > B2) && (C2 > D2))
            {
                Console.WriteLine($"{C2} - наименьшее число");
            }
            else if ((D2 > A2) && (D2 > B2) && (D2 > C2))
            {
                Console.WriteLine($"{D2} - наименьшее число");
            }
        }
    }
}
