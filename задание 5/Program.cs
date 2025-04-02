/*
Записать условие, которое является истинным, когда:
а) каждое из чисел А и В больше 100;
б) хотя бы одно из чисел А и В положительное;
в) каждое из чисел А, В, С кратно (делится без остатка) трем;
г) только одно из чисел А, В и С меньше 50;
д) хотя бы одно из чисел А, В, С отрицательно.
е) каждое из чисел X и Y нечетное;
ж) только одно из чисел X и Y меньше 20;
з) хотя бы одно из чисел X и Y равно нулю;
и) каждое из чисел X, Y, Z отрицательное;
к) только одно из чисел X, Y и Z кратно пяти;
л) хотя бы одно из чисел X, Y, Z  больше 100
*/

namespace задание_5
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
            bool D1 = A1 > 100 && B1 > 100;
            Console.WriteLine($"каждое из чисел А и В больше 100: {D1}");

            Console.Write("б)");
            Console.Write("Введите число A: ");
            double A2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B2 = double.Parse(Console.ReadLine());
            bool D2 = A2 > 0 || B2 > 0;
            Console.WriteLine($"хотя бы одно из чисел А и В положительное: {D2}");

            Console.Write("в)");
            Console.Write("Введите число A: ");
            double A3 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B3 = double.Parse(Console.ReadLine());
            Console.Write("Введите число С: ");
            double C3 = double.Parse(Console.ReadLine());
            bool D3 = (A3 % 3 == 0) && (B3 % 3 == 0) && (C3 % 3 == 0);
            Console.WriteLine($"каждое из чисел А, В, С кратно (делится без остатка) трем: {D3}");

            Console.Write("г)");
            Console.Write("Введите число A: ");
            double A4 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B4 = double.Parse(Console.ReadLine());
            Console.Write("Введите число С: ");
            double С4 = double.Parse(Console.ReadLine());
            bool D4 = (A4 < 50 && B4 >= 50 && С4 >= 50) || (A4 >= 50 && B4 < 50 && С4 >= 50) || (A4 >= 50 && B4 >= 50 && С4 < 50);
            Console.WriteLine($"только одно из чисел А, В и С меньше 50: {D4}");

            Console.Write("д)");
            Console.Write("Введите число A: ");
            double A5 = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B5 = double.Parse(Console.ReadLine());
            Console.Write("Введите число С: ");
            double C5 = double.Parse(Console.ReadLine());
            bool D5 = A5 < 0 || B5 < 0 || C5 < 0;
            Console.WriteLine($"хотя бы одно из чисел А, В, С отрицательно: {D5}");

            Console.Write("е)");
            Console.Write("Введите число X: ");
            double X6 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y6 = double.Parse(Console.ReadLine());
            bool D6 = (X6 % 2 == 1) && (Y6 % 2 == 1);
            Console.WriteLine($"каждое из чисел X и Y нечетное: {D6}");

            Console.Write("ж)");
            Console.Write("Введите число X: ");
            double X7 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y7 = double.Parse(Console.ReadLine());
            bool D7 = (X7 < 20 && Y7 >= 20) || (X7 >= 20 && Y7 < 20);
            Console.WriteLine($"только одно из чисел X и Y меньше 20: {D7}");

            Console.Write("з)");
            Console.Write("Введите число X: ");
            double X8 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y8 = double.Parse(Console.ReadLine());
            bool D8 = X8 == 0 || Y8 == 0;
            Console.WriteLine($"хотя бы одно из чисел X и Y равно нулю: {D8}");

            Console.Write("и)");
            Console.Write("Введите число X: ");
            double X9 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y9 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z9 = double.Parse(Console.ReadLine());
            bool D9 = X9 < 0 && Y9 < 0 && Z9 < 0;
            Console.WriteLine($"каждое из чисел X, Y, Z отрицательное: {D9}");

            Console.Write("к)");
            Console.Write("Введите число X: ");
            double X10 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y10 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z10 = double.Parse(Console.ReadLine());
            bool D10 = (X10 % 5 == 0 && Y10 % 5 != 0 && Z10 % 5 != 0) || (X10 % 5 != 0 && Y10 % 5 == 0 && Z10 % 5 != 0) || (X10 % 5 != 0 && Y10 % 5 != 0 && Z10 % 5 == 0); ;
            Console.WriteLine($"только одно из чисел X, Y и Z кратно пяти: {D10}");

            Console.Write("л)");
            Console.Write("Введите число X: ");
            double X11 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y11 = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z11 = double.Parse(Console.ReadLine());
            bool D11 = X11 > 100 || Y11 > 100 || Z11 > 100;
            Console.WriteLine($"хотя бы одно из чисел X, Y, Z  больше 100: {D11}");
        }
    }
}
