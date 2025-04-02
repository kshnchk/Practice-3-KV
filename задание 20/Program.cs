/*
Дано целое число k (1 <= k <= 365). Определить, каким будет k-й день
года: выходным (суббота и воскресенье) или рабочим, если 1 января —
понедельник.
*/

namespace задание_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите номер дня года (k):");
                int k = int.Parse(Console.ReadLine());

                int d = (k - 1) % 7;

                if (d == 5 || d == 6)
                {
                    Console.WriteLine($"выходной");
                }
                else
                {
                    Console.WriteLine($"рабочий");
                }
            }
    }
}
