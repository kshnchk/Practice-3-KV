﻿/*
Мастям игральных карт условно присвоены следующие порядковые
номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти
«червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,
«тузу» — 14 (порядковые номера карт остальных достоинств соответствуют их
названиям: «шестерка», «девятка» и т. п.). По заданным номеру масти m (1 <=
m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить полное
название (масть и достоинство) соответствующей карты в виде «Дама пик»,
Шестерка бубен» и т. п.
*/

namespace задание_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер масти (1-4):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства (6-14):");
            int k = int.Parse(Console.ReadLine());


            string s = "";
            string r = "";


            if (m == 1)
            {
                s = "Пики";
            }
            else if (m == 2)
            {
                s = "Трефы";
            }
            else if (m == 3)
            {
                s = "Бубны";
            }
            else if (m == 4)
            {
                s = "Червы";
            }

            if (k == 6)
            {
                r = "Шестёрка";
            }
            else if (k == 7)
            {
                r = "Семёрка";
            }
            else if (k == 8)
            {
                r = "Восьмёрка";
            }
            else if (k == 9)
            {
                r = "Девятка";
            }
            else if (k == 10)
            {
                r = "Десятка";
            }
            else if (k == 11)
            {
                r = "Валет";
            }
            else if (k == 12)
            {
                r = "Дама";
            }
            else if (k == 13)
            {
                r = "Король";
            }
            else if (k == 14)
            {
                r = "Туз";
            }

            if (m < 1 || m > 4 || k < 6 || k > 14)
            {
                Console.WriteLine("Некорректные значения. Проверьте номер масти и достоинства.");
            }
            else
            {
                string cardName = $"{r} {s}";
                Console.WriteLine($"Полное название карты: {cardName}");
            }
        }
    }
}
