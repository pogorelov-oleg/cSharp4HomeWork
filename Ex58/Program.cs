int[,] arrayA = new int[,]
{
    {2, 4},
    {3, 2}
};
int[,] arrayB = new int[,]
{
    {3, 4},
    {3, 3}
};

if (CheckUserInput(arrayA, arrayB))
{
    int[,] arrayAB = GetArrayAB(arrayA, arrayB);
    PrintArray(arrayA);
    Console.WriteLine();
    PrintArray(arrayB);
    Console.WriteLine();
    PrintArray(arrayAB);
}
else Console.WriteLine($"Ошибка! Число столбцов первой матрицы не равно числу строк второй матрицы");

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArrayAB(int[,] a, int[,] b)
{
    int[,] ab = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {

            for (int k = 0; k < a.GetLength(1); k++)
            {
                ab[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return ab;
}

bool CheckUserInput(int[,] arrA, int[,] arrB)
{
    return arrA.GetLength(1) == arrB.GetLength(0);
}


