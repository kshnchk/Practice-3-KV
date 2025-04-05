/*
Определить, является ли число, а делителем числа b? А наоборот? (Получить два ответа.)
*/

namespace задание_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine());

            bool AB = (b % a == 0);
            bool BA = (a % b == 0);

            if (AB)
            {
                Console.WriteLine($"{a} является делителем {b}.");
            }
            else
            {
                Console.WriteLine($"{a} не является делителем {b}.");
            }

            if (BA)
            {
                Console.WriteLine($"{b} является делителем {a}.");
            }
            else
            {
                Console.WriteLine($"{b} не является делителем {a}.");
            }
        }
    }
}
