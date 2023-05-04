int i = GetUserNumber($"Введите индекс строки: ", "ОШИБКА! Вы ввели некорректные значения!");
int j = GetUserNumber($"Введите индекс столбца: ", "ОШИБКА! Вы ввели некорректные значения!");
int m = 4;
int n = 6;

int[,] array = GetRandomArray(m, n);
PrintArray(array);
Console.WriteLine();
if (ChekArrayIndex(array, i, j))
{
    Console.WriteLine($"В ячейке [{i}, {j}] находится число {array[i, j]}");
}
else
    Console.WriteLine($"В данном массиве нет ячейки [{i}, {j}]");


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 0)  //добавил проверку, чтобы пользователь не ввел значение < 0
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

int[,] GetRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10 + 1);
        }
    }
    return array;
}

bool ChekArrayIndex(int[,] array, int i, int j)
{
    return i < array.GetLength(0) && j < array.GetLength(1);
}
