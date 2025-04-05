/*
Известны два расстояния: одно в километрах, другое — в футах (1 фут - 0,305 м). Какое из расстояний меньше?
*/

namespace задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние в километрах: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            double B = double.Parse(Console.ReadLine());
            double mA = A * 1000;
            double mB = B * 0.3055;
            Console.WriteLine($"{mA} - километры в метрах");
            Console.WriteLine($" {mB} - футы в метрах");
            if (mA > mB)
            {
                Console.WriteLine($"{mB} - наименьшее расстояние");
            }
            else
            {
                Console.WriteLine($" {mA} - наименьшее расстояние");
            }
        }
    }
}
