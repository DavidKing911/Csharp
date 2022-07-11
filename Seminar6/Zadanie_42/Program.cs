/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
Например:
45 -> 101101
3 -> 11
2 -> 10*/
int a = 13;

void Reshenie(int n)
{
    if(n == 0) return;
    Reshenie(n / 2);
    Console.Write(n % 2);
}

Reshenie(a);