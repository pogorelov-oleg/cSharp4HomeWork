int num = GetUserNumber($"Введите целое число: ", "ОШИБКА! Вы ввели некорректные значения!");

int result = GetSumNumbers (num);
 Console.WriteLine($"Сумма чисел числа {num} -> {result}");
    
int GetSumNumbers (int num)
{
    int result = 0;
    while (num > 0)
    {
       result += num %10;
       num /= 10;
    }
    return result;
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



