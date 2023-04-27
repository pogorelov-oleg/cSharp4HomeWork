int arrayLength = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");
int[] userArray = GetUserArray(arrayLength);
PrintArray(userArray);
int countPositiveNum = GetPositiveNum(userArray);
Console.WriteLine($"Положительных чисел: {countPositiveNum}");

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
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

int[] GetUserArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = GetUserNumber($"Введите {i + 1} число: ", "ОШИБКА! Вы ввели некорректные значения!");
    }
    return arr;
}

int GetPositiveNum(int[] array)
{
    int countPositiveNum = 0;
    foreach (int el in array)
    {
        if (el > 0) countPositiveNum++;
    }
    return countPositiveNum;
}
