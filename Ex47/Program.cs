int m = GetUserNumber($"Введите колличество строк: ", "ОШИБКА! Вы ввели некорректные значения!");
int n = GetUserNumber($"Введите колличество столбцов: ", "ОШИБКА! Вы ввели некорректные значения!");

double [,] array = GetRandomArray (m,n);
PrintArray (array);


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

double[,] GetRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
    }
    return array;
}

void PrintArray(double[,] array)
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