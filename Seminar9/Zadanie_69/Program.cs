/* Напишите программу, которая на выход принимает два числа А и В, 
и возводит число А в целую степень В с помощью рекурсии.
А = 3, В = 5 -> 243
A = 2, B = 3 -> 8 */
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int com = 1;

void NaturalNumbers(int num, int num1, int comp)
{
    if (num1 == 0)
    {
        Console.Write($"{comp}");
        return;
    }
    comp *= a;
    NaturalNumbers(num, num1 - 1, comp);
}

NaturalNumbers(a, b, com);