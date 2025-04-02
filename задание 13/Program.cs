/*
13.Известны две скорости: одна в километрах в час, другая — в метрах в секунду. Какая из скоростей больше?
*/

namespace задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость в км/ч: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите м/с: ");
            double B = double.Parse(Console.ReadLine());
            double mA = A * 1000 / 3600;
            Console.WriteLine($"{mA} - км/ч в м/с");
            if (mA > B)
            {
                Console.WriteLine($"{mA} - наибольшая скорость");
            }
            else
            {
                Console.WriteLine($" {B} - наибольшая скорость");
            }
        }
    }
}
