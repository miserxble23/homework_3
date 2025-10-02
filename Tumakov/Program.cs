using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Enums_1;
using Structs_1;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Упр_1");
            Console.WriteLine();
            Console.Write("Введите число от 1 до 365: ");
            string input1 = Console.ReadLine();
            int dayOfYear1 = int.Parse(input1);

            int[] daysInMonth1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames1 = { "января", "февраля", "марта", "апреля", "мая", "июня","июля", "августа", "сентября", "октября", "ноября", "декабря" };

            int month1 = 0;
            int day1 = dayOfYear1;

            for (int i = 0; i < daysInMonth1.Length; i++)
            {
                if (day1 <= daysInMonth1[i])
                {
                    month1 = i + 1;
                    break;
                }
                else
                {
                    day1 -= daysInMonth1[i];
                }
            }

            DateInfo date1;
            date1.Day = day1;
            date1.Month = month1;

            Console.WriteLine($"Число {dayOfYear1} соответствует {date1.Day} {monthNames1[date1.Month - 1]}");
            Console.WriteLine();

            // 2
            Console.WriteLine("Упр_2");
            Console.WriteLine();
            Console.Write("Введите число от 1 до 365: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int dayOfYear)) // ! - не
            {
                Console.WriteLine("Ошибка! Введите корректное число");
                return; // выход из программы
            }
            if (dayOfYear < 1 || dayOfYear > 365)
            {
                Console.WriteLine("Ошибка: число должно быть от 1 до 365!");
                return;
            }
            int[] daysIsMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 1;
            int day = dayOfYear;
            for (int i = 0; i < daysIsMonth.Length; i++)
            {
                if (day <= daysIsMonth[i])
                {
                    month = i + 1;
                    break;
                }
                else
                {
                    day -= daysIsMonth[i];
                }
            }
            DateInfo date;
            date.Day = day;
            date.Month = month;
            Console.WriteLine($"Число {dayOfYear} соответсвует {date.Day} {monthNames[month - 1]}");
            Console.WriteLine();

            // Дз1
            Console.WriteLine("Дз_1");
            Console.WriteLine();
            Console.Write("Введите год: ");
            string yearInput2 = Console.ReadLine();
            if (!int.TryParse(yearInput2, out int year2))
            {
                Console.WriteLine("Ошибка! Введите корректный год");
                return;
            }
            // Определение високосного года
            bool isLeapYear2 = (year2 % 4 == 0) && (year2 % 100 != 0 || year2 % 400 == 0);

            int maxDays2;
            int febDays2;
            if (isLeapYear2)
            {
                febDays2 = 29;
                maxDays2= 366;
            }
            else
            {
                febDays2 = 28;
                maxDays2 = 365;
            }

            if (isLeapYear2)
            {
                Console.Write("Введите число от 1 до 366: ");
            }
            else
            {
                Console.Write("Введите число от 1 до 365: ");
            }

            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int dayOfYear2))
            {
                Console.WriteLine("Ошибка! Введите корректное число");
                return;
            }

            if (dayOfYear2 < 1 || dayOfYear2 > maxDays2)
            {
                Console.WriteLine($"Ошибка: число должно быть от 1 до {maxDays2}!");
                return;
            }
            int[] daysInMonth2 = { 31, febDays2, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames2 = {"января", "февраля", "марта", "апреля", "мая", "июня","июля", "августа", "сентября", "октября", "ноября", "декабря"};

            int month2 = 0;
            int day2 = dayOfYear2;
            for (int i = 0; i < daysInMonth2.Length; i++)
            {
                if (day2 <= daysInMonth2[i])
                {
                    month2 = i;
                    break;
                }
                day2 -= daysInMonth2[i];
            }
            Console.WriteLine($"Число {dayOfYear2} соответствует {day2} {monthNames2[month]} {year2} года");
            Console.WriteLine($"Год {year2} {(isLeapYear2 ? "високосный" : "не високосный")}"); //условие ? значение_если_истина : значение_если_ложь 


        }
    }
}
