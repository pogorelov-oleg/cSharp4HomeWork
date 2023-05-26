while (true)
{
    int m = GetUserNumber("Введите число M: ", "Error");
    int n = GetUserNumber("Введите число N: ", "Error");
    if (m < n)
    {
        int res = GetElementsSum(m, n);
        Console.WriteLine(res);
        break;
    }
    else Console.WriteLine("Error! Значение M должно быть меньше значения N");
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

int GetElementsSum(int m, int n)
{
    if (m == n) return n;
    return m + GetElementsSum(m + 1, n);
}

