﻿/*
Игральным картам условно присвоены следующие порядковые номера в
зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13,
«тузу» — 14 Порядковые номера остальных карт соответствуют их названиям
(«шестерка», «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14)
определить достоинство соответствующей карты.
*/

namespace задание_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер карты (6 <= k <= 14):");
            int k = Convert.ToInt32(Console.ReadLine());
            string r;

            if (k < 6 || k > 14)
            {
                Console.WriteLine("Некорректный порядковый номер. Пожалуйста, введите число от 6 до 14.");
                return;
            }

            switch (k)
            {
                case 6: r = "Шестёрка"; break;
                case 7: r = "Семёрка"; break;
                case 8: r = "Восмёрка"; break;
                case 9: r = "Девятка"; break;
                case 10: r = "Десятка"; break;
                case 11: r = "Валет"; break;
                case 12: r = "Дама"; break;
                case 13: r = "Король"; break;
                case 14: r = "Туз"; break;
                default: r = "Некорректный номер"; break;
            }

            Console.WriteLine($"Достоинство карты с номером {k}: {r}");
        }
    }
}
