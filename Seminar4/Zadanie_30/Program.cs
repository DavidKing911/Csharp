/*Напишите программу, которая выводит 
массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
Например:
[1, 0, 1, 1, 0, 1, 0, 0]*/
int [] mas = new int[8];
Console.Write("[");
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0,2);
    Console.Write(mas[i]);
    if(i < mas.Length - 1) Console.Write(", ");
}
Console.Write("]");