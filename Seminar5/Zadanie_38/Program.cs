/* Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
Например:
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */
Console.Clear();
Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

double[] Array(int num)
{
    double[] array = new double[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 100) + new Random().NextDouble(), 1);
    }
    return array;
}

double Rezhenie(double[] array)
{
    double max = 0;
    double min = 0;
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else min = array[i];
    }
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Math.Round(result = max - min,1);
    return result;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = Array(num);
PrintArray(array);
double Rez = Rezhenie(array);
Console.Write($" -> {Rezhenie(array)}"); 