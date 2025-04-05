/*
Дата некоторого дня характеризуется двумя натуральными числами:
m (порядковый номер месяца) и n (число). По заданным n и m определить:
а) дату предыдущего дня (принять, что n и m не характеризуют 1 января);
б) дату следующего дня (принять, что n и m не характеризуют 31
декабря).
*/

using System.Text.RegularExpressions;

namespace задание_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, d = 0;

            Console.Write("Введите номер месяца (1-12): ");
            string im = Console.ReadLine();

            // Проверка, что введенное значение является числом
            if (Regex.IsMatch(im, @"^\d+$"))
            {
                m = Convert.ToInt32(im);
            }

            if (m < 1 || m > 12)
            {
                Console.WriteLine("Некорректный номер месяца.");
            }
            else
            {
                Console.Write("Введите число (1-31): ");
                string id = Console.ReadLine();

                // Проверка, что введенное значение является числом
                if (Regex.IsMatch(id, @"^\d+$"))
                {
                    d = Convert.ToInt32(id);
                }

                if (d < 1 || d > 31)
                {
                    Console.WriteLine("Некорректное число.");
                }
                else
                {
                    int dim;
                    // Определение количества дней в месяце
                    if (m == 2)
                        dim = 28;
                    else if (m == 4 || m == 6 || m == 9 || m == 11)
                        dim = 30;
                    else
                        dim = 31;

                    if (d > dim)
                    {
                        Console.WriteLine("Некорректное число для указанного месяца.");
                    }
                    else
                    {
                        int pd, pm;
                        // Вычисление предыдущего дня
                        if (d > 1)
                        {
                            pd = d - 1;
                            pm = m;
                        }
                        else
                        {
                            pm = m - 1;
                            if (pm < 1)
                            {
                                pm = 12;
                                pd = 31;
                            }
                            else
                            {
                                pd = (pm == 2) ? 28 : (pm == 4 || pm == 6 || pm == 9 || pm == 11) ? 30 : 31;
                            }
                        }

                        // Вывод предыдущего дня
                        Console.Write($"а) Предыдущий день: {pd} ");
                        if (pm == 1) Console.WriteLine("января");
                        else if (pm == 2) Console.WriteLine("февраля");
                        else if (pm == 3) Console.WriteLine("марта");
                        else if (pm == 4) Console.WriteLine("апреля");
                        else if (pm == 5) Console.WriteLine("мая");
                        else if (pm == 6) Console.WriteLine("июня");
                        else if (pm == 7) Console.WriteLine("июля");
                        else if (pm == 8) Console.WriteLine("августа");
                        else if (pm == 9) Console.WriteLine("сентября");
                        else if (pm == 10) Console.WriteLine("октября");
                        else if (pm == 11) Console.WriteLine("ноября");
                        else if (pm == 12) Console.WriteLine("декабря");

                        int nd, nm;
                        // Вычисление следующего дня
                        if (d < dim)
                        {
                            nd = d + 1;
                            nm = m;
                        }
                        else
                        {
                            nm = m + 1;
                            if (nm > 12)
                            {
                                nm = 1;
                                nd = 1;
                            }
                            else
                            {
                                nd = 1;
                            }
                        }

                        // Вывод следующего дня
                        Console.Write($"б) Следующий день: {nd} ");
                        if (nm == 1) Console.WriteLine("января");
                        else if (nm == 2) Console.WriteLine("февраля");
                        else if (nm == 3) Console.WriteLine("марта");
                        else if (nm == 4) Console.WriteLine("апреля");
                        else if (nm == 5) Console.WriteLine("мая");
                        else if (nm == 6) Console.WriteLine("июня");
                        else if (nm == 7) Console.WriteLine("июля");
                        else if (nm == 8) Console.WriteLine("августа");
                        else if (nm == 9) Console.WriteLine("сентября");
                        else if (nm == 10) Console.WriteLine("октября");
                        else if (nm == 11) Console.WriteLine("ноября");
                        else if (nm == 12) Console.WriteLine("декабря");
                    }

                }
            }
        }
    }
}
