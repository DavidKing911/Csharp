/* Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;

void NaturalNumbers(int num, int sum)
{
    if(num < 1)
    {
        Console.Write($"Сумма цифр -> {sum}");
        return;
    }
    sum += num % 10;
    NaturalNumbers(num / 10, sum);
}

NaturalNumbers(n, summa);