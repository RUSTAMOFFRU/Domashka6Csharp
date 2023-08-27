// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateUserArray(int m)
{
    int[] arr = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.Write("введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

int CountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите какое количество чисел будете вводить: ");
int numCount = Convert.ToInt32(Console.ReadLine());

int[] array = CreateUserArray(numCount);
PrintArray(array);

int countPositive = CountPositiveNum(array);
Console.WriteLine($"Положительных чисел => {countPositive}");