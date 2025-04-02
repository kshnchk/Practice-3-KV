/*
Даны два различных вещественных числа. Определить наибольшее и
наименьшее из них, не используя полный условный оператор, а применив:
а) два неполных условных оператора;
б) один неполный условный оператор.
*/

namespace задание_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Два неполных операторов
            double max = (num1 > num2) ? num1 : num2;
            double min = (num1 < num2) ? num1 : num2;
            Console.WriteLine($"Наибольшее число: {max}");
            Console.WriteLine($"Наименьшее число: {min}");


            //Один неполный оператор
            double Max = (num1 > num2) ? num1 : num2;
            double Min = num1 + num2 - max;
            Console.WriteLine($"Наибольшее число: {Max}");
            Console.WriteLine($"Наименьшее число: {Min}"); Console.WriteLine("Hello, World!");
        }
    }
}
