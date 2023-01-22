/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Enter a value for B1: ");
double valueB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value for K1: ");
double valueK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value for B2: ");
double valueB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value for K2: ");
double valueK2 = Convert.ToDouble(Console.ReadLine());

double valueX = GetX(valueB1, valueK1, valueB2, valueK2);
double valueY = GetY(valueB1, valueK1, valueB2, valueK2, valueX);

Console.WriteLine($"If B1 = {valueB1}, K1 = {valueK1}, B2 = {valueB2}, K2 = {valueK2};\nX = {valueX}; Y = {valueY}.");

double GetX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double GetY(double b1, double k1, double b2, double k2, double x)
{
    double y = k1 * x + b1;
    return y;
}
