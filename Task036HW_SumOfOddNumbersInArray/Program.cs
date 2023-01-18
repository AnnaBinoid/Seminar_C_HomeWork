/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int size = 5;
int[] myArray = CreateArray(size);
PrintArray(myArray);
int summOddElements = SummOfOddElements(myArray);
Console.WriteLine($"The summ of odd elements in array is {summOddElements}.");

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int SummOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}