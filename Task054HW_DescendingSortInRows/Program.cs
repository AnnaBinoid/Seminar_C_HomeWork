/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int matrixRows = 4;
int matrixColumns = 4;
int minValue = 1;
int maxValue = 11;
int[,] matrixForSort = CreateMatrix(matrixRows, matrixColumns, minValue, maxValue);
PrintMatrix(matrixForSort);
Console.WriteLine(String.Empty);
DescendingSortRows(matrixForSort);
PrintMatrix(matrixForSort);

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

void DescendingSortRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j - 1] <= matrix[i, j])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }
}