/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter three integers separated by Enter!");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
int numberThree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your first integer: {numberOne}, your second integer: {numberTwo}, your third integer: {numberThree}!");
int max = numberOne;


if (max <= numberTwo)
{
    max = numberTwo;
    if (max <= numberThree)
    {
        max = numberThree;
    }
}

Console.WriteLine($"Max from them is {max}!");