/* Напишите программу, которая принимает на вход 
координаты точки (Х и Y), причём Х != 0 и Y != 0
и выдаёт номер четверти плоскости, в которой 
находится эта точка. */
Console.WriteLine("Введите координаты точки");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.Write("Первая четверть");
else if (x < 0 && y > 0) Console.Write("Вторая четверть");
else if (x < 0 && y < 0) Console.Write("Третья четверть");
else if (x > 0 && y < 0) Console.Write("Четвёртая четверть"); 
else Console.Write("Координаты не корректны"); 