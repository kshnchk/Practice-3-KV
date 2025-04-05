/*
Вычислить значение логического выражения при всех возможных
значениях логических величин А, В и С:
а) не (А или не В и С);
б) А и не (В и А или не С);
в) не (не А или В и С)
г) не (А или не В и С) или С;
д) не (А и не В или С) и В;
е) не (не А или В и С) или А.
*/

namespace задание_2
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
            Console.Write("Введите значение C (true/false): ");
            bool C1 = bool.Parse(Console.ReadLine());
            bool R1 = !(A1 || !B1 && C1);
            Console.WriteLine($"не ({A1} или не {B1} и {C1}) = {R1}");

            Console.Write("б)");
            Console.Write("Введите значение А (true/false): ");
            bool A2 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B2 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C2 = bool.Parse(Console.ReadLine());
            bool R2 = A2 && !(B2 && A2 || !C2);
            Console.WriteLine($"{A2} и не({B2} и {A2} или не {C2}) = {R2}");

            Console.Write("в)");
            Console.Write("Введите значение А (true/false): ");
            bool A3 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B3 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C3 = bool.Parse(Console.ReadLine());
            bool R3 = !(!A3 || B3 && C3);
            Console.WriteLine($"не(не {A3} или {B3} и {C3}) = {R3}");

            Console.Write("г)");
            Console.Write("Введите значение А (true/false): ");
            bool A4 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B4 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C4 = bool.Parse(Console.ReadLine());
            bool R4 = !(A4 || !B4 && C4) || C4;
            Console.WriteLine($"не({A4} или не {B4} и {C4}) или {C4}= {R4}");

            Console.Write("д)");
            Console.Write("Введите значение А (true/false): ");
            bool A5 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B5 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C5 = bool.Parse(Console.ReadLine());
            bool R5 = !(A5 && !B5 || C5) && B5;
            Console.WriteLine($"не({A5} и не {B5} или {C5}) и {B5} = {R5}");

            Console.Write("е)");
            Console.Write("Введите значение А (true/false): ");
            bool A6 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B6 = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C6 = bool.Parse(Console.ReadLine());
            bool R6 = !(!A6 || B6 && C6) || A6;
            Console.WriteLine($"не(не {A6} или {B6} и {C6}) или {A6} = {R6}"); ;
        }
    }
}
