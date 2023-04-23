int min = GetUserNumber($"Введите минимальное значение в массиве: ", "ОШИБКА! Вы ввели некорректные значения!");
int max = GetUserNumber($"Введите максимальное значение в массиве: ", "ОШИБКА! Вы ввели некорректные значения!");
int length = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");

int[] arrayRandom = GetRandomArray(min, max, length);
PrintArray(arrayRandom);
int[] arrayUser = GetUserArray(length);
PrintArray(arrayUser);

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int[] GetUserArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetUserNumber($"Введите значение для индекса i = {i}: ", "ОШИБКА! Вы ввели некорректные значения!");
    }
    return array;
}

int[] GetRandomArray(int min, int max, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
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


