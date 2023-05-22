int m = GetUserNumber($"Введите колличество строк: ", "ОШИБКА! Вы ввели некорректные значения!");
int n = GetUserNumber($"Введите колличество столбцов: ", "ОШИБКА! Вы ввели некорректные значения!");

int[,] array = GetRandomArray(m, n);
PrintArray(array);
Console.WriteLine();
int indexMinRow = FindIndexMinRow(array);
Console.WriteLine($"Номер строки наименьшей суммой элементов: {indexMinRow + 1} строка");


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
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindIndexMinRow(int[,] arr)
{
    int minRowSum = RowSum(arr, 0);
    int minSumIndex = 0;

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (RowSum(arr, i) < minRowSum)
        {
            minRowSum = RowSum(arr, i);
            minSumIndex = i;
        }
    }
    return minSumIndex;
}

int RowSum(int[,] arr, int rowIndex)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[rowIndex, j];
    }
    return sum;
}

// *для самостоятельной работы: дописать код, на случай, если будет несколько строк с одинаковым минимальным значением