/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
void FindCrossPoint(double k1, double b1, double k2, double b2)             // Метод нахождения точки пересечения
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

FindCrossPoint(k1, b1, k2, b2);

