/*
Рассчитать значение у при заданном значении y=sin(x) при x>0 или y=cos(x) в противном случае.
*/

namespace задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 0)
            {
                y = Math.Sin(x);
            }
            else
            {
                y = Math.Cos(x);
            }
        }
    }
}
