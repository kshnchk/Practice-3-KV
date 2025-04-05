/*
С начала 1990 года по некоторый день прошло n месяцев и 2 дня.
Определить название месяца (январь, февраль и т. п.) этого дня.
*/

namespace задание_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество месяцев с начала 1990 года (0 или положительное число):");
            int m = Convert.ToInt32(Console.ReadLine());                                        

            int t = m + 1;
            int i = t % 12;


            string n = "";

            if (i == 1) n = "январь";
            else if (i == 2) n = "февраль";
            else if (i == 3) n = "март";
            else if (i == 4) n = "апрель";
            else if (i == 5) n = "май";
            else if (i == 6) n = "июнь";
            else if (i == 7) n = "июль";
            else if (i == 8) n = "август";
            else if (i == 9) n = "сентябрь";
            else if (i == 10) n = "октябрь";
            else if (i == 11) n = "ноябрь";
            else if (i == 0) n = "декабрь";

            Console.WriteLine($"Название месяца: {{name}}");
        }
    }
}
