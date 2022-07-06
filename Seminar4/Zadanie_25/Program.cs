/* Напишите цикл, который принимаетна вход два числа
(А и В) и возводит число А в натуральную степень В.
Например:
3, 5 -> 243 (3^5)
2, 4 -> 16 */
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int Function(int a1, int b1)
{
    int comp = 1;
    for (int step = 1; step <= b1; step++)
    {
        comp = comp * a1;
    }
    return comp;
}
int result = Function(a, b);
Console.Write($"Число {a} в степени {b} -> {result}");