/*
Дата некоторого дня характеризуется двумя натуральными числами:
m (порядковый номер месяца) и n (число). По заданным n и m определить:
а) дату предыдущего дня (принять, что n и m не характеризуют 1 января);
б) дату следующего дня (принять, что n и m не характеризуют 31
декабря).
*/

namespace задание_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца :");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число :");
            int d = Convert.ToInt32(Console.ReadLine());


            if (m < 1 || m > 12 || d < 1 || d > 31)
            {
                Console.WriteLine("Некорректный ввод. Проверьте номер месяца и число.");
                return;
            }


            int daysInMonth = 31;


            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                daysInMonth = 31;
            else if (m == 4 || m == 6 || m == 9 || m == 11)
                daysInMonth = 30;
            else if (m == 2)
                daysInMonth = 28;


            int pd = d;
            int pm = m;

            if (d == 1)
            {

                pm--;
                if (pm < 1)
                {
                    pm = 12;
                }
                pd = getDaysInPreviousMonth(pm);
            }
            else
            {
                pd--;
            }
            Console.WriteLine($"Предыдущий день: {pd} {getMonthName(pm)}");

            int nd = d;
            int nm = m;

            if (d == daysInMonth)
            {

                nd = 1;
                nm++;
                if (nm > 12)
                {
                    nm = 1;
                }
            }
            else
            {

                nd++;
            }
            Console.WriteLine($"Следующий день: {nd} {getMonthName(nm)}");
        }

        static int getDaysInPreviousMonth(int month)
        {

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return 31;
            else if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            else
                return 28;
        }

        static string getMonthName(int month)
        {
            if (month == 1) return "январь";
            if (month == 2) return "февраль";
            if (month == 3) return "март";
            if (month == 4) return "апрель";
            if (month == 5) return "май";
            if (month == 6) return "июнь";
            if (month == 7) return "июль";
            if (month == 8) return "август";
            if (month == 9) return "сентябрь";
            if (month == 10) return "октябрь";
            if (month == 11) return "ноябрь";
            if (month == 12) return "декабрь";
            return "";
        }
    }
}
