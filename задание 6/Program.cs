/*
Записать условие, которое является истинным, когда:
а) целое А кратно двум или трем;
б) целое А не кратно трем и оканчивается нулем.
а) целое N кратно пяти или семи;
б) целое N кратно четырем и не оканчивается нулем.
*/

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а)");
            Console.Write("Введите число A: ");
            double A1 = double.Parse(Console.ReadLine());
            bool D1 = (A1 % 3 == 0) || (A1 % 2 == 0);
            Console.WriteLine($"целое А кратно двум или трем: {D1}");

            Console.Write("б)");
            Console.Write("Введите число A: ");
            double A2 = double.Parse(Console.ReadLine());
            bool D2 = (A2 != 0) && (A2 % 10 == 0);
            Console.WriteLine($"целое А не кратно трем и оканчивается нулем: {D2}");

            Console.Write("a)");
            Console.Write("Введите число N: ");
            double N3 = double.Parse(Console.ReadLine());
            bool D3 = (N3 % 5 == 0) || (N3 % 7 == 0);
            Console.WriteLine($"целое N кратно пяти или семи: {D3}");

            Console.Write("б)");
            Console.Write("Введите число N: ");
            double N4 = double.Parse(Console.ReadLine());
            bool D4 = (N4 % 4 == 0) && (N4 % 10 != 0);
            Console.WriteLine($"целое N кратно четырем и не оканчивается нулем: {D4}");
        }
    }
}
