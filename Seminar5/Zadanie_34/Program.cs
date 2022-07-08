/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2 */
Console.Clear();
Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int Rezhenie(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = Array(num);
PrintArray(array);
int Rez = Rezhenie(array);
Console.Write($" -> {Rezhenie(array)}");