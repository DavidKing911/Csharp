﻿/* Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for(int i = 1; i<= num; i++)
{
    Console.WriteLine($"| Куб числа {i, 2} = |{i*i*i, 5}|");
}