/* Напишите программу, которая задаёт массив из 8 
элементов, заполненный псевдослучайными 
числами и выводит их на экран.
Например:
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */
int [] mas = new int[8];
Console.Write("[");
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(1,100);
    Console.Write(mas[i]);
    if(i < mas.Length - 1) Console.Write(", ");
}
Console.Write("]");