/*
10. Напшите программу, которая принимает на вход трехзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

УТОЧНЕНИЕ: НЕ БЫЛО СКАЗАНО, ЧТО ТРЕХЗНАЧНОЕ ЧИСЛО ДОЛЖНО БЫТЬ 
НАТУРАЛЬНЫМ. ДОБАВИЛА ПРОВЕРКУ НА ОТРИЦАТЕЛЬНЫЕ И ВЫВОЖУ МОДУЛЬ
ВТОРОГО ЧИСЛА.
*/
Console.Write("Enter three-digit number : ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    Console.WriteLine($"Your number is {number}.");

    int secondDigitOfOurNumber = SecondDigitOfNumber(number);
    Console.WriteLine($"Second digit of number {number} is {secondDigitOfOurNumber}.");

    int SecondDigitOfNumber(int ourNumber)
    {
        int secondDigit = Math.Abs((ourNumber % 100 - ourNumber % 10) / 10);
        return secondDigit;
    }
}
else Console.WriteLine($"{number} is not three-digit number. Try again!");