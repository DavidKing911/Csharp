﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5
782 -> 8
918 -> 1 */
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNum = num / 10 % 10;
Console.Write($"Вторая цифра числа {num} -> {secondNum}");