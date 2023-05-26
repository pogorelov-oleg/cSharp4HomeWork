int m = GetUserNumber("Введите число M: ", "Error");
int n = GetUserNumber("Введите число N: ", "Error");\

int res = Akkerman(m, n);
Console.WriteLine($"A({m}, {n}) = {res}");

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

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}






