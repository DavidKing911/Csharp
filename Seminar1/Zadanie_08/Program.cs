﻿/*Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.
Например:
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
Console.Write($"Чётные числа от 1 до {N}: ");
while(a <= N)
{
    if(a % 2 == 0) Console.Write(a);
    a += 2;
    if(a <= N) Console.Write(", ");
}