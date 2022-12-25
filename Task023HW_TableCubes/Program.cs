/*
23. Напишите программу, которая принимает на вход число N
и выдает таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Please, enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);

void Cube (int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($" {i, 4}    |{Math.Pow(i, 3), 4}");
    }
}
