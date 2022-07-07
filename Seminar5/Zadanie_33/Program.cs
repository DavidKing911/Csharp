/* Задайте массив. Напишите программу, которая
определяет, присутсвует ли заданное число в массиве.
Например:
4; массив [6, 7, 19, 345, 3] -> Нет
3; массив [6, 7, 19, 345, 3] -> Да */
Console.Clear();
Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
    return array;
}

string Rezhenie(int[] array, int number)
{
    Console.Write(" -> ");
    string result = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) 
        {
            result = "Да";
            break;
        } 
        else result = "Нет";
    }
    return result;
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
Console.Write(Rezhenie(array, 5));
