/* Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных 
координат точек в этой четверти (х и у). */
Console.Clear();
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1) Console.Write("x > 0 и y > 0");
else if (x == 2) Console.Write("x < 0 и y > 0");
else if (x == 3) Console.Write("x < 0 и y < 0");
else if (x == 4) Console.Write("x > 0 и y < 0");
else Console.Write("Такой четверти не существует");