/*
Дано целое число k (1 <= k <= 365). Определить, каким днем недели
(понедельником, вторником, …, субботой или воскресеньем) является k-й день
не високосного года, в котором 1 января:
а) понедельник;
б) d-й день недели (если 1 января — понедельник, то d = 1,
если вторник — d = 2, …, если воскресенье — d = 7).
*/

namespace задание_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня года:");
            int k = int.Parse(Console.ReadLine());
            int dw = (k - 1) % 7;
            string dn = "";


            if (dw == 0)
            {
                dn = "Понедельник";
            }
            else if (dw == 1)
            {
                dn = "Вторник";
            }
            else if (dw == 2)
            {
                dn = "Среда";
            }
            else if (dw == 3)
            {
                dn = "Четверг";
            }
            else if (dw == 4)
            {
                dn = "Пятница";
            }
            else if (dw == 5)
            {
                dn = "Суббота";
            }
            else if (dw == 6)
            {
                dn = "Воскресенье";
            }

            Console.WriteLine($"{k} день года: {dn}");
            Console.WriteLine("Введите номер дня недели:");
            int d = int.Parse(Console.ReadLine());
            int a = (k - 1 + (d - 1)) % 7;
            string an = "";


            if (a == 0)
            {
                an = "Понедельник";
            }
            else if (a == 1)
            {
                an = "Вторник";
            }
            else if (a == 2)
            {
                an = "Среда";
            }
            else if (a == 3)
            {
                an = "Четверг";
            }
            else if (a == 4)
            {
                an = "Пятница";
            }
            else if (a == 5)
            {
                an = "Суббота";
            }
            else if (a == 6)
            {
                an = "Воскресенье";
            }

            Console.WriteLine($"{k} день года при первом дне недели {d} будет: {an}");
        }
    }
}
