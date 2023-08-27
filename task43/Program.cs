/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//  x=(b1-b2)/(k2-k1)

Console.WriteLine("Ищем координаты точки пересечения прямых (y = k1 * x + b1) и (y = k2 * x + b2)");

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

(double, double) CrossPoint(int bi1, int key1, int bi2, int key2)
{
    double xCross = 0;
    double yCross = 0;

    xCross = (bi1 - bi2) / (key2 - key1);
    yCross = key1 * xCross + bi1;
    return (xCross, yCross);
}

if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые параллельны и не пересекаются");
}
(double, double) crossPoint = CrossPoint(b1, k1, b2, k2);
Console.WriteLine($"Координаты Точки пересечения: {crossPoint}");

