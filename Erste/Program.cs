//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа,
//сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целые числа. Введите 'q' для завершения.");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена по запросу пользователя.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                int digitSum = GetDigitSum(number);

                if (digitSum % 2 == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }
    }

    static int GetDigitSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
