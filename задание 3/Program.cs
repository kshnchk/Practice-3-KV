/*
Вычислить значение логического выражения при всех возможных
значениях логических величин X и Y:
а) (x ∨ y) → (у ≡ x)
б) (x ∨ y) ≡ (у ∧ x)
в) (x ∧ y) ∨ (у → x)
г) (x ≡ y) → у
д) (x ∨ y) → (z ≡ x);
е) (x ≡ (z ∨ y)) ∨ ((x→ z) ∧ (y → x));
ж) y → (z ≡ x);
з) x ≡ (y → z).
*/

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а)");
            Console.Write("Введите значение x (true/false): ");
            bool x1 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y1 = bool.Parse(Console.ReadLine());
            bool r1 = !(x1 || y1) || (y1 == x1);
            Console.WriteLine($"({x1} ∨ {y1}) → ({y1} ≡ {x1}) = {r1}");

            Console.Write("б)");
            Console.Write("Введите значение x (true/false): ");
            bool x2 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y2 = bool.Parse(Console.ReadLine());
            bool r2 = (x2 || y2) == (y2 && x2);
            Console.WriteLine($"({x2} ∨ {y2}) ≡ ({y2} ∧ {x2}) = {r2}");

            Console.Write("в)");
            Console.Write("Введите значение x (true/false): ");
            bool x3 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y3 = bool.Parse(Console.ReadLine());
            bool r3 = (x3 && y3) || (!y3 || x3);
            Console.WriteLine($"({x3} ∧ {y3}) ∨ ({y3} → {x3}) = {r3}");

            Console.Write("г)");
            Console.Write("Введите значение x (true/false): ");
            bool x4 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y4 = bool.Parse(Console.ReadLine());
            bool r4 = !(x4 == y4) || y4;
            Console.WriteLine($"({x4} ≡ {y4}) → {y4} = {r4}");

            Console.Write("д)");
            Console.Write("Введите значение x (true/false): ");
            bool x5 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y5 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение z (true/false): ");
            bool z5 = bool.Parse(Console.ReadLine());
            bool r5 = !(x5 || y5) || (y5 == x5);
            Console.WriteLine($"({x5} ∨ {y5}) → ({z5} ≡ {x5}) = {r5}");

            Console.Write("е)");
            Console.Write("Введите значение x (true/false): ");
            bool x6 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y6 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение z (true/false): ");
            bool z6 = bool.Parse(Console.ReadLine());
            bool r6 = (x6 == (z6 || y6)) || ((!x6 || z6) && (!y6 || x6));
            Console.WriteLine($"({x6} ≡ ({z6} ∨ {y6})) ∨ (({x6}→ {z6}) ∧ ({y6} → {x6})) = {r6}");

            Console.Write("ж)");
            Console.Write("Введите значение x (true/false): ");
            bool x7 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y7 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение z (true/false): ");
            bool z7 = bool.Parse(Console.ReadLine());
            bool r7 = !y7 || (z7 == x7);
            Console.WriteLine($"{y7} → ({z7} ≡ {x7}) = {r7}");

            Console.Write("з)");
            Console.Write("Введите значение x (true/false): ");
            bool x8 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение y (true/false): ");
            bool y8 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение z (true/false): ");
            bool z8 = bool.Parse(Console.ReadLine());
            bool r8 = x8 == (!y8 || z8);
            Console.WriteLine($"{x8} ≡ ({y8} → {z8}) = {r8}");
        }
    }
}
