/*
Вычислить значение логического выражения при всех возможных
значениях логических величин А и В:
а) не (не А и не В) и А;
б) не (не А или не В) или А;
в) не (не А или не В) и В.
*/

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а)");
            Console.Write("Введите значение А (true/false): ");
            bool A1 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B1 = bool.Parse(Console.ReadLine());
            bool C1 = !(!A1 && !B1) && A1;
            Console.WriteLine($"не (не {A1} и не {B1}) и {A1} = {C1}");

            Console.Write("б)");
            Console.Write("Введите значение А (true/false): ");
            bool A2 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B2 = bool.Parse(Console.ReadLine());
            bool C2 = !(!A2 || !B2) || A2;
            Console.WriteLine($"не (не {A2} или не {B2}) или {A2} = {C2}");

            Console.Write("в)");
            Console.Write("Введите значение А (true/false): ");
            bool A3 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B3 = bool.Parse(Console.ReadLine());
            bool C3 = !(!A3 || !B3) && B3;
            Console.WriteLine($"не (не {A3} или не {B3}) и {B3} = {C3}");
        }
    }
}
