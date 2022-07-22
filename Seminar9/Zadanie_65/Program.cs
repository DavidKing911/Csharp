/* Задайте значение M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1, N = 5 -> "1, 2, 3, 4, 5"
M = 3, N = 6 -> "3, 4, 5, 6" */
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num, int num1)
{
    if (num1 > num)
    {
        if (num == num1 + 1) return;
        Console.Write($"{num} ");
        NaturalNumbers(num + 1, num1);
    }
    if (num > num1)
    {
        if (num1 == num + 1) return;
        Console.Write($"{num} ");
        NaturalNumbers(num - 1, num1);
    }
    if(num == num1) Console.Write(num);
}

NaturalNumbers(m, n);