﻿/*Напиши программу, которая принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка)
Например:
4 -> Да
-3 -> Нет
7 -> Нет*/
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0) Console.Write($"{a} - число чётное");
else Console.Write($"{a} - число нечётное");