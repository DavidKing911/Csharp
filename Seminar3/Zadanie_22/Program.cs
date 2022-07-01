/* Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.
Например:
5 -> 1, 4, 9, 16, 25
2 -> 1, 4 */
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for(int i = 1; i<= num; i++)
{
    Console.WriteLine($"| Квадрат числа {i, 2} = |{i*i, 4}|");
}