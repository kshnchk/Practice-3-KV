/*
Определить максимальное и минимальное значения из двух различных вещественных чисел.
*/

namespace задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine($"{A} - наибольшее число; {B} - наименьшее число ");
            }
            else
            {
                Console.WriteLine($"{B} - наибольшее число; {A} - наименьшее число ");
            }
        }
    }
}
