/* Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника. */
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] FillArray(int num)
{
    int[,] arr = new int[num, num];
    for (int i = 0; i < num; i++)
    {
        arr[i, 0] = 1;
        arr[i, i] = 1;
    }
    for (int i = 2; i < num; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
        }
    }
    return arr;
}

void PrintArray(int[,] array, int num)
{
    for (int i = 0; i < num; i++)
    {
        for (int j = 0; j < num; j++)
        {
            if(array[i, j] != 0) Console.Write($"{array[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(n);
PrintArray(array, n);