/*
Задача 52. 
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int matrixRows = 3;
int matrixColumns = 4;
int minValueRnd = 1;
int maxValueRnd = 11;
int[,] matrixRnd = CreateMatrix(matrixRows, matrixColumns, minValueRnd, maxValueRnd);
PrintMatrix(matrixRnd);

Console.WriteLine(String.Empty);

double[] arrAverage = FindAverageInColumns(matrixRnd, matrixColumns, matrixRows);
Console.Write("Arithmetic means of each column are: ");
PrintArray(arrAverage);


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
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

double[] FindAverageInColumns(int[,] matrix, int columns, int rows)
{
    double[] averageInColumns = new double[columns];


    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int summNumInColumn = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summNumInColumn = (summNumInColumn + matrix[j, i]);
        }
        averageInColumns[i] = Math.Round(Convert.ToDouble(summNumInColumn) / Convert.ToDouble(rows), 2);
    }
    return averageInColumns;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}