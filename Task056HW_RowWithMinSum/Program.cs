/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int matrixRows = 4;
int matrixColumns = 4;
int minValue = 1;
int maxValue = 11;
int[,] taskMatrix = CreateMatrix(matrixRows, matrixColumns, minValue, maxValue);
PrintMatrix(taskMatrix);
Console.WriteLine(String.Empty);
int[] sumRowArray = SumRowArray(taskMatrix, matrixRows);
PrintArray(sumRowArray);

Console.WriteLine(String.Empty);
int minSumRowNumber = MinSumRowNumber(sumRowArray);
Console.WriteLine($"The number of the row with the minimum amount is : {minSumRowNumber}!");


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return (matrix);
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

int[] SumRowArray(int[,] matrix, int arrLength)
{

    int[] array = new int[arrLength];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[index] = sum;
        index++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.WriteLine($"The summ of numbers in {i + 1} row is {array[i]}!");
        else Console.WriteLine($"The summ of numbers in {i + 1} row is {array[i]}!");
    }
}

int MinSumRowNumber(int[] array)
{
    int min = array[0];
    int index = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }

    return index + 1;
}