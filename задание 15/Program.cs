/*
Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
Площадь круг S = π*R2; Площадь квадрата S = a2;
*/

namespace задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата:");
            double s = double.Parse(Console.ReadLine());

            double SCircle = Math.PI * r * r;
            double SSquare = s * s;

            Console.WriteLine($"S круга: {SCircle}");
            Console.WriteLine($"S квадрата: {SSquare}");

            if (SCircle > SSquare)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (SCircle < SSquare)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади круга и квадрата равны.");
            }
        }
    }
}
