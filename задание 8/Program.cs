/*
Даны два различных вещественных числа. Определить:
а) какое из них больше;
б) какое из них меньше.
*/

namespace задание_8
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
            if ((A1 > B1) && (A1 > C1))
            {
                Console.WriteLine($"{A1} - наибольшее число");
            }
            else if ((B1 > A1) && (B1 > C1))
            {
                Console.WriteLine($"{B1} - наибольшее число");
            }
            else if ((C1 > A1) && (C1 > B1))
            {
                Console.WriteLine($"{C1} - наибольшее число");
            }
            else
            {
                Console.WriteLine("Введите другое число");
            }

            Console.Write("б)");
            Console.Write("Введите число A: ");
            double A2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C2 = double.Parse(Console.ReadLine());
            if ((A2 < B2) && (A2 < C2))
            {
                Console.WriteLine($"{A1} - наименьшее число");
            }
            else if ((B2 < A2) && (B2 < C2))
            {
                Console.WriteLine($"{B1} - наименьшее число");
            }
            else if ((C2 < A2) && (C2 < B2))
            {
                Console.WriteLine($"{C2} - наименьшее число");
            }
            else
            {
                Console.WriteLine("Введите другое число");
            }
        }
    }
}
