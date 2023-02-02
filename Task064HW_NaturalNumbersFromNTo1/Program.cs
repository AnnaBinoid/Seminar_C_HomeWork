/*
Задача 64: Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.WriteLine("Enter the natural number: ");
string test = Console.ReadLine();
bool result = int.TryParse(test, out var number);
if (result == true)
{
    int n = int.Parse(test);
    if (n > 0)
    {
        Console.Write($"N = {n} -> \"");
        NumbersFromNToOne(n);
        Console.Write("1\"");
    }
    else Console.WriteLine($"{n} is less than 0 or equal to 0, it is not natural number. Try again!");
}
else Console.WriteLine($"{test} is not the natural number or not the number. Try again!");

void NumbersFromNToOne(int num)
{
    if (num == 1) return;
    Console.Write($"{num}, ");
    NumbersFromNToOne(num - 1);
}