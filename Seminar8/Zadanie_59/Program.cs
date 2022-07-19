/* Задайте двумерный массив из целых чисел. Напишите
программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент массива. */

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

int[] NewArrayRowColumn(int[,] arr)
{
    int min = arr[0, 0];
    int[] array = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min)
            {
                min = arr[i, j];
                array[0] = i;
                array[1] = j;
            } 
        }
    }
    return array;
}

int[,] NewMatrix(int[,] arr, int[] newArray)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if(i < newArray[0] && j < newArray[1]) newArr[i, j] = arr[i, j];
            if(i >= newArray[0]) newArr[i, j] = arr[i + 1, j];
            if(j >= newArray[1]) newArr[i, j] = arr[i, j + 1];
            if(i >= newArray[0] && j >= newArray[1]) newArr[i, j] = arr[i + 1, j + 1];
        }
    }
    return newArr;
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
int[] newArray = NewArrayRowColumn(matrixCreate);
int[,] newMatrix = NewMatrix(matrixCreate, newArray);
PrintMatrix(newMatrix);