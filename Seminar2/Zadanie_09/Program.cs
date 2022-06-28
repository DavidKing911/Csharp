/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Например;
78 -> 8
12 -> 2
85 -> 8 */
int newNum = new Random().Next(10,100);
int max(int num)
{
    int num1 = newNum / 10;
    int num2 = newNum % 10;
    if(num1 == num2) return 0;
    return num1 > num2 ? num1 : num2;
}
int newMax = max(newNum);
string result = newMax > 0 ? newMax.ToString() : "числа равны";
Console.Write($"Наибольшая цифра числа {newNum} -> {result}");