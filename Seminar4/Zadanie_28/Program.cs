/* Напишите программу, которая принимает на вход
число N и выдаёт произведение чисел от 1 до N.
Например:
4 -> 24
5 -> 120 */
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int fact = 1;
int Factorial(int number)
{
    for (int i = 1; i <= number; i++)
    {
        fact = fact * i;
    }
    return fact;
}
int rezult = Factorial(num);
Console.Write($"Произведение чисел от 1 до {num} -> {rezult}");