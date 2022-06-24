// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Например:
// a = 25, b = 5 -> Да
// a = 2, b = 10 -> Нет
// a = 9, b = -3 -> Да
// a = -3, b = 9 -> Нет
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
