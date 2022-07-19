/* Составить частотный словарь элементов двумерного
массива. Частотный словарь содержит информацию о 
том, сколько раз встречается элемент входгых данных. */

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void CountElement(int[,] arr)
{
    for (int k = 1; k < 10; k++)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == k) count++;
            }
        }
        if(count > 0)
        {
            if(count > 1 && count < 5) Console.WriteLine($"{k} встречается {count} раза");
            else Console.WriteLine($"{k} встречается {count} раз");
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] matrixCreate = CreateMatrixRndInt(5, 5);
PrintMatrix(matrixCreate);
Console.WriteLine();
CountElement(matrixCreate);