/* Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
Например:
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */
Console.Clear();
Console.WriteLine("Введите N: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    return array;
}

int[] Rezhenie(int[] array)
{
    Console.Write(" -> ");
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] = -array[i];
        else array[i] = -array[i];
    }
    return array;
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
int[] Rez = Rezhenie(array);
PrintArray(Rez);