int m = GetUserNumber($"Введите колличество строк: ", "ОШИБКА! Вы ввели некорректные значения!");
int n = GetUserNumber($"Введите колличество столбцов: ", "ОШИБКА! Вы ввели некорректные значения!");

int[,] array = GetRandomArray(m, n);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

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

int[,] GetRandomArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            arr[i, j] = new Random().Next(0, 10 + 1);
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{i}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] rowToSort = GetRow(arr, i);
        BubbleSort(rowToSort);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rowToSort[j];
        }
    }
}

int[] GetRow(int[,] arr, int rowIndex)
{
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[rowIndex, j];
    }
    return row;
}

void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
            }
        }
    }
}
