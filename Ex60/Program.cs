int x = 2;
int y = 2;
int z = 2;

//int[,,] array = new int[x, y, z];
var array = GetRandomArray(x, y, z);
PrintArray(array);

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] GetRandomArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    InitArrayByNumber(arr, -1000);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int random = new Random().Next(10, 100);
                while (CheckNumInArray(arr, random))
                {
                    random = new Random().Next(10, 100);
                }
                arr[i, j, k] = random;
            }
        }
    }
    return arr;
}

bool CheckNumInArray(int[,,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num) return true;
            }
        }
    }
    return false;
}

void InitArrayByNumber(int[,,] arr, int initNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = initNumber;
            }
        }
    }
}
