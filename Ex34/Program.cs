﻿int countMin = GetUserNumber($"Введите минимальное значение в массиве: ", "ОШИБКА! Вы ввели некорректные значения!");
int countMax = GetUserNumber($"Введите максимальное значение в массиве: ", "ОШИБКА! Вы ввели некорректные значения!");
int arrLength = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");

int[] arr = GetRandomArray(countMin, countMax, arrLength);
PrintArray(arr);
int countEven = GetCountEven(arr);
Console.WriteLine($"В заданном массиве {countEven} четных элементов");

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int[] GetRandomArray(int countMin, int countMax, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(countMin, countMax + 1);
    }
    return array;
}

int GetCountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}
