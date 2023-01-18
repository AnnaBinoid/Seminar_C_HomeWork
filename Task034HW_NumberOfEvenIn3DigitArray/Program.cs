/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.
 
 [345, 897, 568, 234] -> 2
    */
int size = 10;
int[] array = CreateArray(size);
PrintArray(array);
int count = CountOfEven(array);
Console.WriteLine($"The number of even numbers in this array is {count}.");

int[] CreateArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length - 1; i++)
    {
        Console.Write($"{myArray[i]}, ");
    }
    Console.WriteLine(myArray[myArray.Length - 1]);
}

int CountOfEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}