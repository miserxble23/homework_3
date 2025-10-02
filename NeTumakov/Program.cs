using System;
using Enums_2;
using Enums_4;

namespace NeTumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("№1");
            Console.WriteLine();
            int[] numbers = new int[10];

            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.Write($"Число {i + 1}: ");
                    string input1 = Console.ReadLine();
                    if (int.TryParse(input1, out numbers[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите целое число.");
                    }
                }
            }
            int breakIndex = -1; // Индекс числа, нарушающего порядок

            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    breakIndex = i + 1;
                    break;
                }
            }
            if (breakIndex == -1) //eсли значение осталось -1
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию."); // все оке
            }
            else
            {
                Console.WriteLine($"Число {numbers[breakIndex - 1]} не больше предыдущего числа {numbers[breakIndex - 2]}"); // анлак
            }
            Console.WriteLine("Введенная последовательность:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            // 2
            Console.WriteLine();
            Console.WriteLine("№2");
            try
            {
                Console.Write("Введите номер карты (6-14): ");
                int number = int.Parse(Console.ReadLine());

                if (number < 6 || number > 14)
                    throw new Exception("Номер карты должен быть от 6 до 14"); // throw кидает в catch

                CardRank rank = (CardRank)number;
                Console.WriteLine($"Карта: {rank} ({(int)rank})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
            Console.WriteLine();
            // 3
            Console.WriteLine();
            Console.WriteLine("№3");
            Console.Write("Кто вы(jabroni, school counselor, programmer, bike gang member, politician, rapper)? ");
            string input = Console.ReadLine().ToLower();
            string drink;
            if (input == "jabroni")
                drink = "Patron Tequila";
            else if (input == "school counselor")
                drink = "Anything with Alcohol";
            else if (input == "programmer")
                drink = "Hipster Craft Beer";
            else if (input == "bike gang member")
                drink = "Moonshine";
            else if (input == "politician")
                drink = "Your tax dollars";
            else if (input == "rapper")
                drink = "Cristal";
            else
                drink = "Beer";
            Console.WriteLine($"Ваш напиток: {drink}");
            Console.WriteLine();
            // 4
            Console.WriteLine();
            Console.WriteLine("№4");
            Console.Write("Введите номер дня недели (1-7): ");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    WeekDay day = (WeekDay)dayNumber;
                    Console.WriteLine($"День недели: {day}");
                }
                else
                {
                    Console.WriteLine("Ошибка: номер дня должен быть от 1 до 7");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число");
            }
            Console.WriteLine();
            // 5
            Console.WriteLine();
            Console.WriteLine("№5");
            string[] toys = { "Car", "Hello kitty", "Barbie doll", "lego", "Hello kitty","Barbie doll","Labubu1", "Labubu2"};
            int count = 0; // счетчик
            foreach (string toy in toys) 
            { 
                if (toy=="Hello kitty" || toy == "Barbie doll")
                {
                    count += 1;
                }
            }

            Console.WriteLine($"Количество кукол в сумке: {count}");

            Console.WriteLine();

        }
    }
}
