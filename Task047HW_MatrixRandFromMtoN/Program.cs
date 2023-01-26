/*
Задача 47. 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int mRows = 3;
int nColumns = 4;
double minValue = -10;
double maxValue = 10;
double[,] matrixRand = CreateMatrix(mRows,nColumns, minValue, maxValue);
PrintMatrix(matrixRand);

double[,] CreateMatrix(int rows, int columns, double max, double min)
{
    Random rnd = new Random();
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min),2);
        }
    }
    return matrix;
}

void PrintMatrix (double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"  |{matrix[i, j], 6} | ");
        }
        Console.WriteLine($"]", 6);
    }
}

