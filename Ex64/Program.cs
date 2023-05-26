while (true)
{
    int n = GetUserNumber("Введите число N: ", "Error");
    int finalDig = GetUserNumber("Введите последнее число: ", "Error");
    if (n > finalDig)
    {
        string res = PrintNaturalNums(n, finalDig);
        Console.WriteLine(res);
        break;
    }
    else Console.WriteLine("Error! Конечное число должно быть меньше значения N");
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

string PrintNaturalNums(int n, int finalDig)
{
    if (n == finalDig) return n.ToString();
    return n + " " + PrintNaturalNums(n - 1, finalDig);
}
