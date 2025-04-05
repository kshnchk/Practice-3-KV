/*
Даны два прямоугольника, стороны которых параллельны или
перпендикулярны осям координат. Известны координаты левого нижнего угла
каждого из них и длины их сторон. Один из прямоугольников назовем первым,
другой — вторым.
а) Определить, принадлежат ли все точки первого прямоугольника
второму.
б) Определить, принадлежат ли все точки одного из прямоугольников
другому.
в) Определить, пересекаются ли эти прямоугольники.
*/

namespace задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите левый нижний угол первого прямоугольника:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширина и высота первого прямоугольника:");
            double w1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите левый нижний угол второго прямоугольника:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширина и высота второго прямоугольника:");
            double w2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());

            double x1Max = x1 + w1;
            double y1Max = y1 + h1;
            double x2Max = x2 + w2;
            double y2Max = y2 + h2;

            if (x1 >= x2 && y1 >= y2 && x1Max <= x2Max && y1Max <= y2Max)
            {
                Console.WriteLine("Все точки первого прямоугольника принадлежат второму.");
            }
            else
            {
                Console.WriteLine("Не все точки первого прямоугольника принадлежат второму.");
            }

            if (x2 >= x1 && y2 >= y1 && x2Max <= x1Max && y2Max <= y1Max)
            {
                Console.WriteLine("Все точки второго прямоугольника принадлежат первому.");
            }
            else
            {
                Console.WriteLine("Не все точки второго прямоугольника принадлежат первому.");
            }

            if (!(x1Max <= x2 || x2Max <= x1 || y1Max <= y2 || y2Max <= y1))
            {
                Console.WriteLine("Прямоугольники пересекаются.");
            }
            else
            {
                Console.WriteLine("Прямоугольники не пересекаются.");
            }
        }
    }
}
