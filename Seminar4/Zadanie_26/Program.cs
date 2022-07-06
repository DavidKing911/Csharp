/* Напишите программу, которая принимает на вход
число и выдаёт количество цифр в числе.
Например:
456 -> 3
78 -> 2
89126 -> 5 */
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
int Num(int number)
{
    while (number > 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}
int result = Num(num);
Console.Write($"Количество цифр числа {num} -> {count}"); 