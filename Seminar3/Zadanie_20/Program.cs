/* Напишите программу, которая 
принимает на вход координаты 
двух точек и находит расстояние 
между ними в 2D пространстве.
Например:
А (3, 6); В (2, 1) -> 5.09
A (7, -5); B (1, -1) -> 7,21 */
Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("Х: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("Х: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write($"Расстояние между точками: {Math.Round(Math.Sqrt
(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2)}");
