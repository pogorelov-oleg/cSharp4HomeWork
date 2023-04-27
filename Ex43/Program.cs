double b1 = GetUserNumber($"Введите значение b1: ", "ОШИБКА! Вы ввели некорректные значения!");
double k1 = GetUserNumber($"Введите значение k1: ", "ОШИБКА! Вы ввели некорректные значения!");
double b2 = GetUserNumber($"Введите значение b2: ", "ОШИБКА! Вы ввели некорректные значения!");
double k2 = GetUserNumber($"Введите значение k2: ", "ОШИБКА! Вы ввели некорректные значения!");

double x = GetX(b1, k1, b2, k2);
double y = GetY(b1, k1, b2, k2);

Console.WriteLine($"b1({b1}), k1({k1}), b2({b2}), k2({k2}) -> ({x}; {y})");

double GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

double GetX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double GetY(double b1, double k1, double b2, double k2)
{
    double y = k2 * GetX(b1, k1, b2, k2) + b2;
    return y;
}

//  y = k1 * x + b1,   заданная формула
//  y = k2 * x + b2;   заданная формула
//
//  k1 * x + b1 = k2 * x + b2     находим x
//  k1 * x - k2 * x = b2 - b1     находим x
//  x(k1 - k2) = b2 - b1          находим x
//  GetX = (b2 - b1) / (k1 - k2)  конечная формула для метода X
//  GetY = k2 * GetX + b2;        конечная формула для метода Y






