/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Enter the natural number: ");
string test1 = Console.ReadLine();
Console.WriteLine("Enter the natural number: ");
string test2 = Console.ReadLine();

bool result1 = int.TryParse(test1, out var numberN);
bool result2 = int.TryParse(test2, out var numberM);

if (result1 && result2)
{
    int m = int.Parse(test1);
    int n = int.Parse(test2);
    int result = 0;
    if (m < 0 || n < 0)
    {
        Console.Write($"You enter \"{test1} \"and \"{test2} \". One or both of them are less than zero. Try again!");

    }
    if (m == n) Console.WriteLine($"You entered the same numbers: \"{m} \"and \"{n} \". Try again!");

    if (m < n && (m > 0 && n > 0))
    {
        result = SumOfNaturalNumbersFromMtoN(m, n);
        Console.Write($"The sum of natural numbers from {m} to {n} is {result}.");
    }
    if (n < m && (m > 0 && n > 0))
    {
        result = SumOfNaturalNumbersFromMtoN(n, m);
        Console.Write($"The sum of natural numbers from {m} to {n} is {result}.");
    }

}
else Console.Write($"You enter \"{test1} \"and \"{test2} \". One or both of them are not natural numbers or not numbers. Try again!");


int SumOfNaturalNumbersFromMtoN(int min, int max)
{
    if (min == max) return min;
    else return (max + SumOfNaturalNumbersFromMtoN(min, max - 1));

}