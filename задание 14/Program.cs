/*
Дано натуральное число.
а) Верно ли, что оно заканчивается четной цифрой?
б) Верно ли, что оно заканчивается нечетной цифрой?
*/

namespace задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int num = int.Parse(Console.ReadLine());
            int lastnum = num % 10;

            if (lastnum % 2 == 0)
            {
                Console.WriteLine("Число заканчивается четной цифрой.");
            }
            else
            {
                Console.WriteLine("Число заканчивается нечетной цифрой.");
            }
    }
}
