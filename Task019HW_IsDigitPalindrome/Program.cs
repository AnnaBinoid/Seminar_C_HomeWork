/*
19. Напишите программу, которая
принимает на вход пятизначное число,
проверяет, является ли оно палиндромом.

14212 - нет
23432 - да
12821 - да
*/

Console.WriteLine("Please, enter a five-digit number : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[5];


if ((userNumber < 100000 && userNumber > 9999) || (userNumber > -100000 && userNumber < -9999))
    {
        Console.WriteLine ($"Your number is : {userNumber}!");

        FillArray(myArray, userNumber);
        int myResult = ReverseDigit(myArray);
        Console.WriteLine($"Let's turn it over! Now it is {myResult}!");

        Console.WriteLine(userNumber == myResult ? $"Yes, your number is palindrom!" : $"No, your number is not palindrom!");
        
    }
else Console.WriteLine($"{userNumber} is not five-digit. Try again, please!");


void FillArray (int[] array, int number)
{
    int length = array.Length;
    
    for (int i = 0; i <= length-1; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }   
}

int ReverseDigit (int[] newArray)
{
    int result = 0;
    int multiplier = 1;
    for (int k = newArray.Length-1; k >= 0; k--)
    {
        result = result + newArray[k]*multiplier;
        multiplier = multiplier*10;
    }
    return result;
    
}
