/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
Console.Clear();
Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
    return array;
}

int Rezhenie(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100)
        {
            count += 1;
        }
        
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