/*
Задача 27.
Напишите программу, которая 
принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Please, enter your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int absUsernumber = Math.Abs(userNumber);

int numberLength = NumberLength(absUsernumber);
//Console.WriteLine($"The length of your number is {numberLength}.");

int[] digits = ArrNumberDigits(absUsernumber, numberLength);
//PrintArray(digits);

int numberSum = SumNumDigits(digits);
Console.WriteLine($"The sum of digits of your number {userNumber} is {numberSum}.");

int NumberLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}

int[] ArrNumberDigits(int numberUser, int length)
{
    int index = 0;

    int[] numberDigits = new int[length];

    
    while (numberUser > 0)
    {
        numberDigits[index] = numberUser % 10;
        numberUser = numberUser / 10;
        index++;
    }
    return numberDigits;
}

int SumNumDigits (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

/*void PrintArray (int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write($"{printArray[i]} ");
    }
}
*/