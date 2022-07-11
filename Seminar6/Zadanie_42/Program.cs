/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
Например:
45 -> 101101
3 -> 11
2 -> 10*/
/* Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Reshenie (int number)
{
    if (number == 1) return 1;
    if (number == 0) return 0;
    return number % 2 + 10 * Reshenie(number / 2);
}

Console.Write(Reshenie(a)); */

int a = 13;

void Reshenie(int n)
{
    if(n == 0) return;
    Reshenie(n / 2);
    Console.Write(n % 2);
}

Reshenie(a);