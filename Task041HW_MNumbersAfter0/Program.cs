/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Please, enter the number of numbers: ");
int numberOfNumbers = Convert.ToInt32(Console.ReadLine());
if (numberOfNumbers > 0)
{
    int[] userArray = CreateAndFillArray(numberOfNumbers);
    PrintArray(userArray);
    int numberOfPositiveNumbers = NumberOfPositiveNumbers(userArray);
    Console.WriteLine($"The number of positive numbers in array is {numberOfPositiveNumbers}.");
}
else Console.WriteLine($"Your number {numberOfNumbers} is not natural, enter another number > 0!");

int[] CreateAndFillArray(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter another number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i < printArray.Length - 1) Console.Write($"{printArray[i]}, ");
        else Console.WriteLine($"{printArray[i]}]");
    }

}

int NumberOfPositiveNumbers(int[] thisArray)
{
    int count = 0;
    for (int i = 0; i < thisArray.Length; i++)
    {
        if (thisArray[i] > 0) count++;

    }
    return count;
}