/* Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int number1 = 0;
int Num(int number)
{
    while (number > 0)
    {
        number1 = number % 10;
        sum += number1;
        number /= 10;
    }
    return sum;
}
int result = Num(num);
Console.Write($"Сумма цифр числа {num} -> {result}");