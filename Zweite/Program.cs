//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        const int arraySize = 10;

        // Создаем массив случайных трёхзначных чисел
        int[] randomNumbers = GenerateRandomNumbers(arraySize);

        // Выводим массив
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(randomNumbers);

        // Подсчитываем количество четных чисел
        int evenCount = CountEvenNumbers(randomNumbers);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000); // Генерация случайных трёхзначных чисел
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}