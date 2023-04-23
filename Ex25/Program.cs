int a = GetUserNumber($"Введите число A: ", "ОШИБКА! Вы ввели некорректные значения!");
int b = GetUserNumber($"Введите число B: ", "ОШИБКА! Вы ввели некорректные значения!");

double pow = GetPow(a, b);
Console.WriteLine($"{a}, {b} -> {pow}");

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

int GetPow(int a, int b)
{
int result = a;
    while (b > 1)
    {
        result *= a;
        b--;
    }
    return result;
}