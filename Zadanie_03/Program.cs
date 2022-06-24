// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница
//int Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7;
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("День недели: ");
if(a == 1) Console.WriteLine("Понедельник");
else if(a == 2) Console.WriteLine("Вторник");
else if(a == 3) Console.WriteLine("Среда");
else if(a == 4) Console.WriteLine("Четверг");
else if(a == 5) Console.WriteLine("Пятница");
else if(a == 6) Console.WriteLine("Суббота");
else if(a == 7) Console.WriteLine("Воскресенье");
else Console.Write("Ошибка");