int m = 4;
int n = 4;
int[,] spiralArray = GetSpiralArray(m, n);
PrintArray(spiralArray);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:00}\t");
        }
        Console.WriteLine();
    }
}

int[,] GetSpiralArray(int m, int n)
{
    int[,] arr = new int[m, n];
    int stepNumber = 1;
    int farLeft = 0;
    int farRight = n - 1;
    int farTop = 0;
    int farBottom = m - 1;
    while (stepNumber <= m * n)
    {
        for (int i = farLeft; i <= farRight; i++)
        {
            arr[farTop, i] = stepNumber;
            stepNumber++;
        }
        farTop++;
        for (int i = farTop; i <= farBottom; i++)
        {
            arr[i, farRight] = stepNumber;
            stepNumber++;
        }
        farRight--;
        for (int i = farRight; i >= farLeft; i--)
        {
            arr[farBottom, i] = stepNumber;
            stepNumber++;
        }
        farBottom--;
        for (int i = farBottom; i >= farTop; i--)
        {
            arr[i, farLeft] = stepNumber;
            stepNumber++;
        }
        farLeft++;
    }
    return arr;
}

