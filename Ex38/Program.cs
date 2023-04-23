int arrLength = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");

double[] arr = GetRandomArray(arrLength);
PrintArray(arr);
double minNum = GetMinNum(arr);
double maxNum = GetMaxNum(arr);
double result = maxNum - minNum;
Console.WriteLine($"Разница между максимальным ({maxNum}) и минимальным ({minNum}) элементом массива равна {result}");

void PrintArray(double[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 0);
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

double GetMinNum(double[] arr)
{
    double min = arr[0];
    foreach (double el in arr)
    {
        if (el < min) min = el;
    }
    return min;
}

double GetMaxNum(double[] arr)
{
    double max = arr[0];
    foreach (double el in arr)
    {
        if (el > max) max = el;
    }
    return max;
}
