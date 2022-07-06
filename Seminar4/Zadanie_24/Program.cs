/* Напишите программу, которая принимает на вход
число (А) и выдаёт сумму чисел от 1 до А.
Например:
7 -> 28
4 -> 10
8 -> 36 */
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int Sum(int collection)
{
    int sum = 0;
    for (int n = 1; n <= a; n++)
    {
        sum += n;
    }
    return sum;
}
int result = Sum(a);
Console.Write($"Сумма чисел от 1 до {a} -> {result}");