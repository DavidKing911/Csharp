/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Например:
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

void Reshenie(int number)
{
    int[] f = new int[number];
    int num1 = 0;
    int num2 = 1;
    if(number == 1 || number == 0) Console.Write(num1);
    else Console.Write(num1 + " " + num2 + " ");
    for (int i = 2; i < number; i++)
    {
        f[0] = 0;
        f[1] = 1;
        f[i]= f[i-1] + f[i-2];
        Console.Write(f[i] + " ");
    }
}

Reshenie(n);