/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Add your positive integer, please!");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (number < 0)
{
    Console.WriteLine($"The pozitive number must be greater than zero. {number} is not positiv. Try again!");
}

else
{

    while (count + 1 < number)
    {
        count = count + 2;
        Console.Write($"{count}, ");

    }

}
