/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

void Reshenie(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count += 1;
    }
    Console.Write(count);
}

int[] array = new int[4]{3,4,-2,-1};//[размер массива]{числа}
Reshenie(array);