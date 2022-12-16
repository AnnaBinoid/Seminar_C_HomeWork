//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
// Уточнить в условии насчет диапазона, который может вводить пользователь, т.к. диапазон Int от -2147483648 до 2147483647

Console.WriteLine("Enter two integers separated by Enter!");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your first integer is {numberOne}, your second integer is {numberTwo}!");

if (numberOne > numberTwo)
{
    Console.WriteLine($"Max from them is the first one: {numberOne}!");
}
if (numberOne < numberTwo)
{
    Console.WriteLine($"Max from them is the second one: {numberTwo}!");
}
else Console.WriteLine($"The numbers {numberOne} and {numberTwo} are equal to each other");