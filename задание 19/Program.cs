/*
Имеются стол прямоугольной формы с размерами a x b (a и b — целые
числа, a > b) и кости домино с размерами c x d x e (c, d и e — целые числа, c >
d > e). Найти вариант размещения на столе наибольшего количества костей.
Все размещаемые кости должны лежать на одной и той же грани в один ярус
без свешивания со стола. Все ребра костей домино
или перпендикулярны каждой стороне стола.
*/

namespace задание_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры стола:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите размеры домино:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());


            int c1 = (a / c) * (b / d);
            int c2 = (a / c) * (b / e);
            int c3 = (a / d) * (b / e);
            int c4 = (a / d) * (b / c);
            int c5 = (a / e) * (b / c);
            int c6 = (a / e) * (b / d);


            int maxC = Math.Max(Math.Max(Math.Max(c1, c2), Math.Max(c3, c4)), Math.Max(c5, c6));


            Console.WriteLine($"Максимальное количество костей: {maxC}");
        }
    }
}
