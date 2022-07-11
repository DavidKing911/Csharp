/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник 
с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона 
треугольника меньше суммы двух других сторон.*/
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

void Reshenie (int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.Write("Такой треугольник существует");
    else Console.Write("Треугольника с такими сторонами не существует");
}

Reshenie(a, b, c);