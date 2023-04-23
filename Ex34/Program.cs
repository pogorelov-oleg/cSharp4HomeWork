int arrLength = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");

int[] arr = GetRandomArray(arrLength);
PrintArray(arr);
int countEven = GetCountEven(arr);
Console.WriteLine($"В заданном массиве {countEven} четных элементов");

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetCountEven(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count += 1;
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

