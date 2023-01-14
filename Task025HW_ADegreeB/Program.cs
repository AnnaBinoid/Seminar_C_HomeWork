/*
Задача 25 
Напишите цикл, который 
принимает на вход два числа (A и B),
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Please enter the number a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter the number b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool areNatural = AreNatural(numberA, numberB);
if (areNatural != true)
{
int aDegreeB = Degree(numberA, numberB);

Console.WriteLine ($"{numberA} to the degree of {numberB} is {aDegreeB}.");}


bool AreNatural(int a, int b)
{
    if ((a <= 0) || (b <=0))
    {
        if (a <= 0)
        {
            Console.WriteLine($"Your first number {a} is not natural. Try again!");
        }
        if (b <= 0)
        {
            Console.WriteLine($"Your second number {b} is not natural. Try again!");
        }
    return true;
    }
    else return false;
    
}

int Degree (int number1, int number2)
{
    int degree = Convert.ToInt32(Math.Pow(number1, number2));
    return degree;
}