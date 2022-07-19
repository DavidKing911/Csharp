/* Задайте двумерный массив. Напишите 
программу, которая поменяет местами 
первую и последнюю строку массива. */
Console.Clear();

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

int[,] NewMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int temp = arr[0, j];
            arr[0, j] = arr[arr.GetLength(0) - 1, j];
            arr[arr.GetLength(0) - 1, j] = temp;
        }
    }
    return arr;
} 

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
            else Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] matrixCreate = CreateMatrixRndInt(5, 5);
PrintMatrix(matrixCreate);
Console.WriteLine();
int[,] newMatrix = NewMatrix(matrixCreate);
PrintMatrix(newMatrix);