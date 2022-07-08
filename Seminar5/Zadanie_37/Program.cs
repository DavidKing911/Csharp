/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
Console.Clear();
Console.Write("Введите N: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

int[] Rezhenie(int[] array)
{
    Console.Write(" -> ");
    int pro = 0;
    int x = 0;
    if(num % 2 == 1) x = num + 1;
    if(num % 2 == 0) x = num;
    int[] mas = new int[(x/2)];
    for(int i = 0; i < array.Length/2; i++)
    {
        pro = array[i] * array[array.Length - 1 - i];
        mas[i] = pro;
    }
    if (num % 2 == 1) mas[mas.Length-1] = array[array.Length/2];
    return mas;
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
int[] massive = Rezhenie(array);
PrintArray(massive);