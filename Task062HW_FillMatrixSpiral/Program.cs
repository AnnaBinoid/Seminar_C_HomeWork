/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int matrixRows = 4;
int matrixColumns = 4;

double[,] taskMatrix = CreateMatrix(matrixRows, matrixColumns);
PrintMatrix(taskMatrix);

double[,] CreateMatrix(int rows, int columns)
{

    double[,] matrix = new double[rows, columns];

    int fillNumber = 1;
    int rI = 0;
    int cI = 0;
    int indexRow = 0;  //1
    int indexCol = columns - 1;  //2

    while (cI < columns)
    {
        matrix[rI, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        cI++;
    }

    rI = rI + 1;
    cI = indexCol;

    while (rI < indexCol)
    {
        matrix[rI, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        rI++;
    }

    while (cI > indexRow)
    {
        matrix[rI, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        cI--;
    }
    // rI 3, cI 0

    while (rI > indexRow)
    {
        matrix[rI, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        rI--;
    }

    indexRow = indexRow + 1; // 1
    indexCol = indexCol - 1; //2
    rI++;
    cI++;

    while (cI <= indexCol)
    {
        matrix[rI, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        cI++;
    }
    
    cI--;
    indexRow = indexRow + 1; // 2
    indexCol = indexCol - 1; // 1

    while (cI >= indexCol)
    {
        matrix[indexRow, cI] = fillNumber;
        fillNumber = fillNumber + 1;
        cI--;

    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine($"]", 6);
    }
}

