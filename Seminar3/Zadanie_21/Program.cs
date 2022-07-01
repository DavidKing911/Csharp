/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние
между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("Х: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("Х: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z: ");
int z2 = int.Parse(Console.ReadLine());
Console.Write($"Расстояние между точками: {Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2)}");