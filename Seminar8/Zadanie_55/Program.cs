/* Задайте двумерный массив. Напишите
программу, которая заменяет строки
на столбцы. В случае, если это 
невозможно, программа должна вывести
сообщение для пользователя. */
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

void NewMatrix(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Матрица не квадратная");
    }
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
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

int[,] matrixCreate = CreateMatrixRndInt(4, 5);
PrintMatrix(matrixCreate);
Console.WriteLine();
NewMatrix(matrixCreate);
Console.WriteLine();
PrintMatrix(matrixCreate);