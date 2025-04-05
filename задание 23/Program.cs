/*
Имеется стол прямоугольной формы с размерами a x b (a и b — целые
числа, a > b). В каком случае на столе можно разместить большее количество
картонных прямоугольников с размерами c x d (c и d — целые числа, c > d):
при размещении их длинной стороной вдоль длинной стороны стола или вдоль
короткой. Прямоугольники не должны лежать один на другом и не должны
свисать со стола.
*/

namespace задание_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры стола:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите размеры картонных прямоугольников:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int count1 = (a / c) * (b / d);
            int count2 = (a / d) * (b / c);

            if (count1 > count2)
            {
                Console.WriteLine($"{count1} можно разместить, если длинная сторона вдоль длинной стороны стола.");
            }
            else if (count2 > count1)
            {
                Console.WriteLine($"{count2} можно разместить, если длинная сторона вдоль короткой стороны стола.");
            }
            else
            {
                Console.WriteLine($"Количество прямоугольников одинаково {count1}.");
            }
        }
    }
}
